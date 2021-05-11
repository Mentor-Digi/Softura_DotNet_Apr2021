using EFandLINQProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFandLINQProject
{
    class Program
    {
        PostRepo postRepo;
        CommentRepo commentRepo;
        TweetContext context;
        Program()
        {
            context = new TweetContext();
            commentRepo = new CommentRepo(context);
            postRepo = new PostRepo(context);
        }
        void PrintPostWithComments()
        {
            //select postid,posttext, commentid,commnettext from post p join comment c on p.id = c.postid
            //group by postid
            var postWiseComment = context.Comments.ToList().GroupBy(c => c.PostId);
            foreach (var postComment in postWiseComment)
            {
                int id = postComment.Key; ;
                Post post = postRepo.Get(id);
                PrintPost(post);
                Console.WriteLine("Comment for this post");
                foreach (var comment in postComment)
                {
                    PrintComment(comment);
                }
                Console.WriteLine("-------------------------------------------------------");
            }
        }
        void PrintComment(Comment comment)
        {
            Console.WriteLine("Comment id "+comment.Id);
            Console.WriteLine(comment.CommenText);
        }
        void AddPost()
        {
            Console.WriteLine("Please enter the Post Category");
            string category = Console.ReadLine();
            Console.WriteLine("Please enter the Post Text");
            string text = Console.ReadLine();
            Post post = new Post();
            post.Category = category;
            post.PostText = text;
            if(postRepo.Add(post))
                Console.WriteLine("The post is posted");
            else
                Console.WriteLine("Could not post");
        }
        void PrintPosts()
        {
            var posts = postRepo.GetAll();
            if(posts != null)
                foreach (var item in posts.ToList())
                {
                    PrintPost(item);
                }
        }
        void PrintPost(Post post)
        {
            Console.WriteLine("Post Id " + post.Id);
            Console.WriteLine("Post Category " + post.Category);
            Console.WriteLine("Post  " + post.PostText);
        }
        void AddCommentToPost()
        {
            PrintPosts();
            int id = 0;
            Console.WriteLine("Please enter the id for which you want to comment");
            id = Convert.ToInt32(Console.ReadLine());
            Post post = postRepo.Get(id);
            if(post!=null)
            {
                PrintPost(post);
                Comment comment = TakeComment(id);
                if(commentRepo.Add(comment))
                    Console.WriteLine("Comment updated");
            }
        }

        private Comment TakeComment(int pid)
        {
            Comment comment = new Comment();
            comment.PostId = pid;
            Console.WriteLine("Please enter the comment");
            comment.CommenText = Console.ReadLine();
            return comment;
        }
        void UserInterface()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Add comment to post");
                Console.WriteLine("3. View all posts");
                Console.WriteLine("4. View Postwise comment");
                Console.WriteLine("5. exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPost();
                        break;
                    case 2:
                        AddCommentToPost();
                        break;
                    case 3:
                        PrintPosts();
                        break;
                    case 4:
                        PrintPostWithComments();
                        break;
                    case 5:
                        Console.WriteLine("Exiting....");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice!=5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tweets");
            new Program().UserInterface();
            Console.ReadKey();
        }
    }
}
