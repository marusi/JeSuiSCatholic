using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace JeSuiSCatholic.ViewModels
{
    public class ArticleViewModel
    {
        private static Random s_random = new Random();
        private string _headline;
        private Uri _imageUri;

        public string Headline
        {
            get { return _headline; }
            set { _headline = value; }
        }

        public ImageSource ImageSource
        {
            get { return new BitmapImage(_imageUri); }
        }

        public string FullText
        {
            get
            {
                return
                @"Our Father, who art in heaven, hallowed be thy name. Thy kingdom come; Thy will be done on earth,
				 as it is in heaven. Give us this day our daily bread, and forgive us our trespasses, as we forgive 
				 those who trespass against us, and lead us not into temptation, but deliver us from evil. Amen.


				Formerly the collect for Ember Saturday in Lent, this prayer is now used on the Thursday after Ash Wednesday. 
				Lord, may everything we do begin with your inspiration and continue with your help, so that all our 
				prayers and works may begin in you and by you be happily ended. We ask this through Christ our Lord. Amen. 

                V. O Lord open our lips R. And we shall praise your name. Glory be to the Father, and to the Son, and to the Holy Spirit, 
				as it was in the beginning, is now and ever shall be, world without end. Amen. (Alleluia)
			 	(A suitable hymn such as the following is said) Transcendent God in whom we live, The Resurrection and the Light, 
				 We sing for you a morning hymn, To end the silence of the night.
                When early cock begins to crow, And everything from sleep awakes, New life and hope spring up again, 
				While out of darkness colour breaks.
				Creator of all things that are, The measure and the end of all, Forgiving God, forget our sins, And hear our prayer before we call.

                Formerly the collect for Ember Saturday in Lent, this prayer is now used on the Thursday after Ash Wednesday. 
				Lord, may everything we do begin with your inspiration and continue with your help, so that all our 
				prayers and works may begin in you and by you be happily ended. We ask this through Christ our Lord. Amen. 

                V. O Lord open our lips R. And we shall praise your name. Glory be to the Father, and to the Son, and to the Holy Spirit, 
				as it was in the beginning, is now and ever shall be, world without end. Amen. (Alleluia)
			 	(A suitable hymn such as the following is said) Transcendent God in whom we live, The Resurrection and the Light, 
				 We sing for you a morning hymn, To end the silence of the night.
                When early cock begins to crow, And everything from sleep awakes, New life and hope spring up again, 
				While out of darkness colour breaks.
				Creator of all things that are, The measure and the end of all, Forgiving God, forget our sins, And hear our prayer before we call.";
            }
        }



        public string FullText2
        {
            get
            {
                return
                @"Our Father, who art in heaven, hallowed be thy name. Thy kingdom come; Thy will be done on earth,
				 as it is in heaven. Give us this day our daily bread, and forgive us our trespasses, as we forgive 
				 those who trespass against us, and lead us not into temptation, but deliver us from evil. Amen.


				Formerly the collect for Ember Saturday in Lent, this prayer is now used on the Thursday after Ash Wednesday. 
				Lord, may everything we do begin with your inspiration and continue with your help, so that all our 
				prayers and works may begin in you and by you be happily ended. We ask this through Christ our Lord. Amen. 

                V. O Lord open our lips R. And we shall praise your name. Glory be to the Father, and to the Son, and to the Holy Spirit, 
				as it was in the beginning, is now and ever shall be, world without end. Amen. (Alleluia)
			 	(A suitable hymn such as the following is said) Transcendent God in whom we live, The Resurrection and the Light, 
				 We sing for you a morning hymn, To end the silence of the night.
                When early cock begins to crow, And everything from sleep awakes, New life and hope spring up again, 
				While out of darkness colour breaks.
				Creator of all things that are, The measure and the end of all, Forgiving God, forget our sins, And hear our prayer before we call.

                Formerly the collect for Ember Saturday in Lent, this prayer is now used on the Thursday after Ash Wednesday. 
				Lord, may everything we do begin with your inspiration and continue with your help, so that all our 
				prayers and works may begin in you and by you be happily ended. We ask this through Christ our Lord. Amen. 

                V. O Lord open our lips R. And we shall praise your name. Glory be to the Father, and to the Son, and to the Holy Spirit, 
				as it was in the beginning, is now and ever shall be, world without end. Amen. (Alleluia)
			 	(A suitable hymn such as the following is said) Transcendent God in whom we live, The Resurrection and the Light, 
				 We sing for you a morning hymn, To end the silence of the night.
                When early cock begins to crow, And everything from sleep awakes, New life and hope spring up again, 
				While out of darkness colour breaks.
				Creator of all things that are, The measure and the end of all, Forgiving God, forget our sins, And hear our prayer before we call.";
            }
        }

        public ArticleViewModel()
        {
            _headline = new[]
                {
                    "Catholic",
                    "Faith",
                    "The Pope",
                    "vatican",
                    "Assumption of Mary",
                    "The Virgin Mary",
                    "Jesus",
                    "Universal Church",
                    "Our faith",
                    "The ten Commandments"
                }[s_random.Next(10)];

            var imagePath = "Images/circle_image" + (s_random.Next(3) + 1).ToString() + ".jpg";
            _imageUri = new Uri("ms-appx:///" + imagePath);
        }
    }
}
