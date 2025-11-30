using Newtonsoft.Json;
using QuizApp.Data;
using System.Net;

namespace QuizApp.Functionality
{
    public class APIHelper
    {
        public List<Topic> QuestionTopic { get; set; }
        public List<CategoryParameter> QuestionCategory { get; set; }
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

                QuestionTopic = JsonConvert.DeserializeObject<List<Topic>>(stringContent);
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine(ex.StackTrace + "  " + ex.Message);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("");

            return QuestionTopic;
        }
        public async Task<List<CategoryParameter>> GetCategoryQuestions(HttpClient httpClient, string NameOfCategory)
        {
            var response = await httpClient.GetAsync($"/api/v1/questions?category={NameOfCategory}");

            //Deserijalizacija
            var stringContent = await response.Content.ReadAsStringAsync();
            QuestionCategory = JsonConvert.DeserializeObject<List<CategoryParameter>>(stringContent);
            Console.WriteLine("");
            return QuestionCategory;
        }
    }
}
