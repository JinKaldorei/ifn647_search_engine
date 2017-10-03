using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser

namespace IFN647_SearchEngine
{
    public class LuceneSearch
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;

        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";

        public LuceneSearch()
        {
            luceneIndexDirectory = null;
            analyzer = null;
            writer = null;
        }

        /// <summary>
        /// Creates the index at indexPath
        /// </summary>
        /// <param name="indexPath">Directory path to create the index</param>
        public void CreateIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);

        }

        /// <summary>
        /// Indexes the given text
        /// </summary>
        /// <param name="text">Text to index</param>
        public void IndexText(string text)
        {
            Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Document doc = new Document();
            doc.Add(field);
            writer.AddDocument(doc);
        }

        /// <summary>
        /// Flushes buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
        }
        public void CreateParser()
        {
            parser = new QueryParser(VERSION, TEXT_FN, analyzer);

        }

        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }
        public TopDocs SearchIndex(string queryStr)
        {
            Console.WriteLine($"Searching for: {queryStr}");
            Query query = parser.Parse(queryStr);
            TopDocs results = searcher.Search(query, 100);
            Console.WriteLine($"Number of results is {results.TotalHits}");
            return results;
        }
        public void DisplayResults(TopDocs topDocs)
        {
            int i = 1;
            foreach (ScoreDoc scoreDoc in topDocs.ScoreDocs)
            {
                Document doc = searcher.Doc(scoreDoc.Doc);
                string text = doc.Get(TEXT_FN).ToString();
                Console.WriteLine($"Rank {i++} Text: {text}");
            }
        }
        static void Main(string[] args)
        {

            LuceneSearch myLuceneApp = new LuceneSearch();

            // TODO: ADD PATHNAME
            string indexPath = @"C:\w5_index\";

            myLuceneApp.CreateIndex(indexPath);

            System.Console.WriteLine("Adding Documents to Index");

            List<string> l = new List<string>();
            l.Add("IPhone 7 dasd");
            l.Add("Samsung 6 sadd");
            l.Add("Windows 10 sadsa d");
            l.Add("Iphone 6 sadsa d");
            l.Add("Iphone 5s sadsa d");
            l.Add("Samsung Galaxy Note 6 sadsa d");

            ///
            l.Add("hieutran106@gmail.com");
            l.Add("abc@gmail.com");
            l.Add("hieutran106@yahoo.com");
            l.Add("asdsad@yahoo123.com");

            foreach (string s in l)
            {
                System.Console.WriteLine("Adding " + s + "  to Index");
                myLuceneApp.IndexText(s);
            }

            System.Console.WriteLine("All documents added.");
            //create searcher & parser
            myLuceneApp.CreateSearcher();
            myLuceneApp.CreateParser();
            //query
            TopDocs topDocs = myLuceneApp.SearchIndex("hieutran106@gmail.com");
            myLuceneApp.DisplayResults(topDocs);
            // clean up
            myLuceneApp.CleanUpSearcher();
            myLuceneApp.CleanUpIndexer();


            System.Console.ReadLine();


        }
    }
}