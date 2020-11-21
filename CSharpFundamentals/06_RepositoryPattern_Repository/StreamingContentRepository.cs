using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {

        private List<StreamingContent> _listOfContent = new List<StreamingContent>();

        
        
        //Create 
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        //read 
        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }

        //update 
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //find the content
            StreamingContent OldContent = GetContentByTitle(originalTitle);

            //update the content
            if(OldContent != null)
            {
                OldContent.Title = newContent.Title;
                OldContent.Description = newContent.Description;
                OldContent.MaturityRating = newContent.MaturityRating;
                OldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                OldContent.StarRating = newContent.StarRating;
                OldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }


        //delete
        public bool RemoveContentFromList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if( content == null)
            {
                return false; 
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if(initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //helper method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _listOfContent)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }
    }
}
