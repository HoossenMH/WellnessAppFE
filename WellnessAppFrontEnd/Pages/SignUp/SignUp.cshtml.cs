using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WellnessAppFrontEnd.Pages
{
    public class SignUpModel
    {
        private static HttpClient client = new HttpClient();        

        public void OnGet()
        {
            //client.BaseAddress = new Uri("http://localhost:3308/signUps");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            //var x = GetProductAsync();
        }

        static async Task<Modals.SignUp> GetProductAsync()
        {
            Modals.SignUp product = null;
            HttpResponseMessage response = await client.GetAsync("/signUp/AllSignUp");
            //if (response.IsSuccessStatusCode)
            //{
            //    product = await response.Content.ReadAsAsync<Modals.SignUp>();
            //}
            return product;
        }
    }
}