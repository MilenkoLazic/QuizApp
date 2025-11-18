using Newtonsoft.Json;
using QuizApp.Data;

namespace QuizApp.Functionality
{
    public class APIHelper
    {
        public List<Topic> QuestionCategory { get; set; }
        public APIHelper()
        {
            
        }
        public async Task<List<Topic>> GetCategoryTopics(string Token,HttpClient httpClient)
        {
            
            var response = await httpClient.GetAsync("/api/v1/categories");

            //Deserijalizacija
            var stringContent = await response.Content.ReadAsStringAsync();
            try
            {

                QuestionCategory = JsonConvert.DeserializeObject<List<Topic>>(stringContent);
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine(ex.StackTrace + "  " + ex.Message);
            }
            Console.WriteLine("");

            return QuestionCategory;
        } 
    }
}
