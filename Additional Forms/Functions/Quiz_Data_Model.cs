using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;





/// <summary>
/// This file contains numerous object collection on which could represent as individual objects instances in JSON
///  Such could be stored in a collection of a  Generic type
/// All objects can be serialized/deserialized  using JSON
/// </summary>

namespace Quizlett_Prototype.Additional_Forms.Functions
{

    public class Quiz_Data_Model
    {

        public string? quiz_name { get; set; } // Name of the quiz 
        public string? type { get; set; } // On the other defintions - this often refer to as 'quizMode'
        public string? quiz_id { get; set; } // TDOD: Might not be implemented due to complexity
        public string? quiz_description { get; set; } // nullable
        public string? Subject { get; set; } // nullable

        public string ImagePath { get; set;  } 
        public bool isTimerEnabled { get; set; }    // nullable


        #region Score and Timer Statistics
        // Implementation of LinkList as question objects collection
        public LinkedList<QuestionModel> collection_Questions = new LinkedList<QuestionModel>();

        // Base score property 
        public double? score = 0;

        // Data to display how long did the player take to finish all the questions in the quiz
        public int? finalTime { get; set;  }


        // Implement a priority Queue to sort and display scores
        public  PriorityQueue<int, int> Time_collection = new PriorityQueue<int, int>();

        // Hashset
        public  HashSet<int> Scores_collection = new HashSet<int>();



        #endregion

        // Constructor
        public Quiz_Data_Model()
        {
            this.quiz_name = "Untitled Quiz Game";
            this.type = "MC";
            this.quiz_description = "Untitled Quiz";
            this.Subject = "Not Set";
            this.isTimerEnabled = true;
        }

    }

    #region Question Model data
    public class QuestionModel 
    {

        public string Question { get; set; }
        public string correct_Answer { get; set; }

        public int question_number { get; set; }

       
        public string? ImagePath { get; set; }

        // Default Constructor 
        public QuestionModel()
        {
            this.Question = "Oppps, Looks like we've made some mistakes!! -- Nothing to see here";
            this.correct_Answer = "None";
        }

    }

    public class QuestionModel_MultipleChoice : QuestionModel
    {

        // Serve as a collection of choices
        public string[]? choices_Collection = new string[4];

    }

    public class QuestionModel_Identification : QuestionModel
    {
        // Empty for future updates
    }


    // Optional QuizMode
    // This function is under the Beta Model and may not  be included as the main function
    public class QuestionModel_FillBlanks : QuestionModel
    {
     
        // Empty for future updates
    }


    #endregion

    #region Data Storage Ckass
    public class Data_Storage
    {
        // Universal data storage
        public static LinkedList<Quiz_Data_Model> quiz_list = new LinkedList<Quiz_Data_Model>();

    }
    #endregion


    #region JSON Serializer and Deserializer

    public class JsonMethods
    {

        public static void Serialize()
        {
            string json = JsonConvert.SerializeObject(Data_Storage.quiz_list, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,// Include type information
                Formatting = Formatting.Indented,
               
                
                
            });

            File.WriteAllText(@"QuizData.json", json);
        }

        public static void Deserialize()
        {

            if (File.Exists("QuizData.json"))
            {
                string jsonString = File.ReadAllText("QuizData.json");

                Data_Storage.quiz_list  = JsonConvert.DeserializeObject<LinkedList< Quiz_Data_Model>>(jsonString, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All, // Use the type information to correctly deserialize
                    Formatting = Formatting.Indented,
                   
                });


                // Catch potential null values
                if (Data_Storage.quiz_list == null) {

                    Data_Storage.quiz_list = new LinkedList<Quiz_Data_Model>(); 
                }
               

            }

        }


        // Not Implemented 
        // Issue thrown: OutOfMemoryexception, Due to the large sum of memory taken by base 64 encoding
        #region Explicit castings on deserialization

        public static LinkedList<QuestionModel> templateCollection;



        #endregion

    }
    #endregion

    #region StatisticsDataModel

    public class StatisticModel() {

        // Trim excess methods
        public static void TrimExcessData(PriorityQueue<int, int> a ) {

            while (a.Count > 5) { 
                a.Dequeue();
            }
        }

        public static HashSet<int> TrimExcessData(HashSet<int> a)
        {
            List<int> b = new List<int>(a);
            
            while (b.Count > 5)
            {
                b.RemoveAt(0);
            }

             HashSet<int> c = new HashSet<int>(b);

            return c;
        }


    }

    
    #endregion

    // Unused annotation for Binary and Base  64 conversion
    #region Annotation Conversion for Bitmaps 


    /// <summary>
    /// An anntotation base collections of methods that converts a bitmat into a base 64 string data of Bitmap
    /// </summary>
    public class BitmapJsonConverter : JsonConverter
    {

        // Checks if the file/ image file is on the type of bitmap
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Bitmap);
        }


        // Read and validates Json
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var base64String = reader.Value as string; // Cast to string 
            if (string.IsNullOrEmpty(base64String)) return null;

            var bytes = Convert.FromBase64String(base64String); // Convert to base 64
            using (var ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is Bitmap bitmap)
            {
                using (var ms = new MemoryStream())
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    var base64String = Convert.ToBase64String(ms.ToArray());
                    writer.WriteValue(base64String);
                }
            }
            else
            {
                writer.WriteNull();
            }
        }
    }
    #endregion // Unused

}
