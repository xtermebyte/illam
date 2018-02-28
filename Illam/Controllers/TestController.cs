using Illam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Illam.Controllers
{
    public class TestController : ApiController
    {
        const string ImagesFolder = ""; // "/illam/Images/";
        const string QuestionsImageFolder = ""; // "/illam/Images/Test1/";
        Dictionary<int, string> answerKey;
        test1
        Test
            test2

            test5

        public TestController()
        {
            answerKey = new Dictionary<int, string>();

            answerKey.Add(1, "B");
            answerKey.Add(2, "C");
            answerKey.Add(3, "C");
            answerKey.Add(4, "A");
            answerKey.Add(5, "A");
            answerKey.Add(6, "B");
            answerKey.Add(7, "C");
            answerKey.Add(8, "A");
            answerKey.Add(9, "C");
            answerKey.Add(10, "D");
            answerKey.Add(11, "C");
            answerKey.Add(12, "D");
            answerKey.Add(13, "C");
            answerKey.Add(14, "A");
            answerKey.Add(15, "B");
            answerKey.Add(16, "A");
            answerKey.Add(17, "B");
            answerKey.Add(18, "B");
            answerKey.Add(19, "B");
            answerKey.Add(20, "C");
            answerKey.Add(21, "C");
            answerKey.Add(22, "D");
            answerKey.Add(23, "A");
            answerKey.Add(24, "B");
            answerKey.Add(25, "D");
            answerKey.Add(26, "A");
            answerKey.Add(27, "B");
            answerKey.Add(28, "C");
            answerKey.Add(29, "C");
            answerKey.Add(30, "C");
            answerKey.Add(31, "B");
            answerKey.Add(32, "D");
            answerKey.Add(33, "A");
            answerKey.Add(34, "B");
            answerKey.Add(35, "B"); // SAMPLE TEST PRE-JUNIOUR
            answerKey.Add(36, "B");
            answerKey.Add(37, "C");
            answerKey.Add(38, "B");
            answerKey.Add(39, "B");
            answerKey.Add(40, "C"); //WEEK1 PRE-J
            answerKey.Add(41, "C");
            answerKey.Add(42, "B");
            answerKey.Add(43, "B");
            answerKey.Add(44, "D");
            answerKey.Add(45, "B"); //WEEK2 PRE-J
            answerKey.Add(46, "B");
            answerKey.Add(47, "D");
            answerKey.Add(48, "A");
            answerKey.Add(49, "D");
            answerKey.Add(50, "C"); //Week3
            /*answerKey.Add(51, "B");
            answerKey.Add(52, "B");
            answerKey.Add(53, "B");
            answerKey.Add(54, "B");
            answerKey.Add(55, "B");
            answerKey.Add(56, "B");
            answerKey.Add(57, "B");
            answerKey.Add(58, "B");
            answerKey.Add(59, "B");
            answerKey.Add(60, "B");
            answerKey.Add(61, "B");
            answerKey.Add(62, "B");
            answerKey.Add(63, "B");
            answerKey.Add(64, "B");
            answerKey.Add(65, "B");
            answerKey.Add(66, "B");
            answerKey.Add(67, "B");
            answerKey.Add(68, "B");
            answerKey.Add(69, "B");
            answerKey.Add(70, "B");
            answerKey.Add(71, "B");
            answerKey.Add(72, "B");
            answerKey.Add(73, "B");
            answerKey.Add(74, "B");
            answerKey.Add(75, "B");
            answerKey.Add(76, "B");
            answerKey.Add(77, "B");
            answerKey.Add(78, "B");
            answerKey.Add(79, "B");
            answerKey.Add(80, "B");
            answerKey.Add(81, "B");
            answerKey.Add(82, "B");
            answerKey.Add(83, "B");
            answerKey.Add(84, "B");
            answerKey.Add(85, "B");
            answerKey.Add(86, "B");
            answerKey.Add(87, "B");
            answerKey.Add(88, "B");
            answerKey.Add(89, "B");
            answerKey.Add(90, "B");
            answerKey.Add(91, "B");
            answerKey.Add(92, "B");
            answerKey.Add(93, "B");
            answerKey.Add(94, "B");
            answerKey.Add(95, "B");
            answerKey.Add(96, "B");
            answerKey.Add(97, "B");
            answerKey.Add(98, "B");
            answerKey.Add(99, "B");*/
        }


        // GET: api/Test
        public TestModel Get()
        {
            int totQ = 45;
/*            for (int i = 0; i < 100; i++)
                Debug.WriteLine("answerKey.Add(" + i.ToString() + ", \"B\");");
                */
            var retData = new TestModel();
            string baseURI = HttpContext.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.Url.AbsolutePath, "");
            baseURI = "";

            retData.RightImage = baseURI + ImagesFolder + "Correct.PNG";
            retData.WrongImage = baseURI + ImagesFolder + "Wrong.jpg";

            retData.Questions = new List<Models.QuestionModel>();

            for (int i = 1; i < totQ + 1; i++)
            {
                var ques = new QuestionModel();
                ques.QNo = i.ToString();
                ques.ImageURL = baseURI + QuestionsImageFolder + "q" + i.ToString() + ".PNG";
                ques.Answer = answerKey[i];
                retData.Questions.Add(ques);
            }

            Random rand = new Random();
            retData.Questions = retData.Questions.OrderBy(c => rand.Next()).ToList();
            for (int i = 0; i < totQ; i++)
            {
                var ques = retData.Questions[i];
                ques.QNo = (i + 1).ToString();
            }

                return retData;

        }

        /*// GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }*/
    }
}
