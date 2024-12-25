﻿using System;
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

        [JsonConverter(typeof(BitmapJsonConverter))]
        public Bitmap? imageProfile { get; set; } // nullable
        public bool isTimerEnabled { get; set; }    // nullable

        // Implementation of LinkList as question objects collection
        public LinkedList<QuestionModel> collection_Questions = new LinkedList<QuestionModel>();

        // Base score property 
        public double? score = 0;



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

        [JsonConverter(typeof(BitmapJsonConverter))]
        public Bitmap? image { get; set; }

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

    }


    // Optional QuizMode
    // This function is under the Beta Model and may not  be included as the main function
    public class QuestionModel_FillBlanks : QuestionModel
    {
        public string a { get; set; }

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
                    Formatting = Formatting.Indented
                });


                // Catch potential null values
                if (Data_Storage.quiz_list == null) {

                    Data_Storage.quiz_list = new LinkedList<Quiz_Data_Model>(); 
                }
               

            }

        }


        // Not Implemented
        #region Explicit castings on deserialization

        public static LinkedList<QuestionModel> templateCollection;



        #endregion

    }
    #endregion


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
    #endregion

}
