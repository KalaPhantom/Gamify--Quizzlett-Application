using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;



/// <summary>
/// This file contains numerous object collection on which could represent as individual objects instances in JSON
///  Such could be stored in a collection of a  Generic type
/// All objects can be serialized/deserialized  using JSON
/// </summary>

namespace Quizlett_Prototype.Additional_Forms.Functions
{

 
    internal class Quiz_Data_Model
    {
        public string quiz_name { get; set; }
        public string type { get; set;  }
        public string quiz_id { get; set; }
        public string quis_description {get; set;}
        public string Subject { get ; set;}


        // Constructor
        public Quiz_Data_Model() {
            this.quiz_name = "Untitled Quiz Game";
            this.type = "Multiple Choices";
            this.quiz_name = null;
        
        }

        // Implementation of LinkList as question objects collection
        public LinkedList<QuestionModel> collections_Questions = new LinkedList<QuestionModel>();

    }

    #region Question Model data
    public class QuestionModel {

        
        public string Question { get; set; }
        public string correct_Answer { get; set; }

        public QuestionModel() {
            this.Question = "None";
            this.correct_Answer = "None";
        
        }
    
    }

    public class QuestionModel_MultipleChoice : QuestionModel{ 
 
        // Serve as a collection of choices
        public Queue<string> choices_Collection = new Queue<string>();
    
    }


    // Optional QuizMode
    public class QuestionModel_FillBlanks : QuestionModel {
    
    }


    #endregion
}
