using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    public interface ITalkable
    {
        void TellMeAboutAgeInEnglish();
        void TellMeAboutFavorFoodInEnglish();
        void TellMeAboutNameInEnglish();
    }
    public class EnglishSpeakerKid : ITalkable
    {
        #region ITalkable Members

        public void TellMeAboutAgeInEnglish()
        {
            Console.WriteLine("English - Age");
        }

        public void TellMeAboutFavorFoodInEnglish()
        {
            Console.WriteLine("English - Food");
        }

        public void TellMeAboutNameInEnglish()
        {
            Console.WriteLine("English - Name");
        }

        #endregion
    }

    public class AdaptorForNonEnglshSpeaker : ITalkable
    {
        private NonEnglishSpeaker _aNonEnglishSpeaker = new NonEnglishSpeaker();
        #region ITalkable Members

        public void TellMeAboutAgeInEnglish()
        {
            Console.WriteLine(_aNonEnglishSpeaker.Age);
        }

        public void TellMeAboutFavorFoodInEnglish()
        {
            Console.WriteLine(_aNonEnglishSpeaker.FavFood);
        }

        public void TellMeAboutNameInEnglish()
        {
            Console.WriteLine(_aNonEnglishSpeaker.Name);
        }

        #endregion
    }

    public sealed class NonEnglishSpeaker
    {
        public int Age { get; set; }
        public string FavFood { get; set; }
        public string Name { get; set; }

        
        public NonEnglishSpeaker() {

            Age = 10;
            FavFood = "Apples";
            Name = "Louis";
        }

    }


    public interface ICommunicator {
        ITalkable ObjectToTalkTo { get; set; }
        void StartChatting();
    }

    public class Teacher : ICommunicator
    {
        #region ICommunicator Members

        public ITalkable ObjectToTalkTo
        {
            get; set;
        }

        #endregion

        #region ICommunicator Members


        public void StartChatting()
        {
            ObjectToTalkTo.TellMeAboutAgeInEnglish();
            ObjectToTalkTo.TellMeAboutFavorFoodInEnglish();
            ObjectToTalkTo.TellMeAboutNameInEnglish();
        }

        #endregion
    }

}
