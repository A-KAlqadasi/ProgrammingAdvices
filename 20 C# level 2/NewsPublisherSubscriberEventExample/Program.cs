using System;
using System.Threading;


namespace NewsPublisherSubscriberEventExample
{
    public class Article
    {
        public string Title { get; }
        public string Content { get; }
        public Article(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }

    public class NewsPublisher
    {
        public event EventHandler<Article> NewNewsPublished;

        public void PublishNewNews(string title, string content)
        {
            var article = new Article(title, content);
            OnNewNewsPublished(article);
        }

        protected virtual void OnNewNewsPublished(Article article)
        {
            NewNewsPublished?.Invoke(this, article);
        }
    }

    public class NewsSubscrber
    {
        public string Name { get; set; }

        public NewsSubscrber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(NewsPublisher pubscrber)
        {
            pubscrber.NewNewsPublished += HandlerNewNews;
        }
        public void UnSubscribe(NewsPublisher pubscrber)
        {
            pubscrber.NewNewsPublished -= HandlerNewNews;
        }

        private void HandlerNewNews(object sender, Article e)
        {
            Console.WriteLine($"\n{Name} recived new news");
            Console.WriteLine($"Title: {e.Title}");
            Console.WriteLine($"Content: {e.Content}");
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher pubscrber = new NewsPublisher();
            NewsSubscrber subscrber1 = new NewsSubscrber("Subscriber 1");
            NewsSubscrber subscrber2 = new NewsSubscrber("Subscriber 2");
            subscrber1.Subscribe(pubscrber);
            subscrber2.Subscribe(pubscrber);

            pubscrber.PublishNewNews("Breaking News", "A significant event just happend!");
            pubscrber.PublishNewNews("Tech Update", "New gadgets are hitting the market");

            // unsubscriber a subscriber
            subscrber1.UnSubscribe(pubscrber);

            pubscrber.PublishNewNews("Weather Forecast", "Expect sunny weather this weekend");

            subscrber2.UnSubscribe(pubscrber);
            pubscrber.PublishNewNews("Final Edition", "Last news update for today");






            Console.ReadKey();
        }
    }
}
