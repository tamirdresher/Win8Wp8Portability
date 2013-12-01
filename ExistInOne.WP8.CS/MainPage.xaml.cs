using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExistInOne.WP8.CS.Resources;

namespace ExistInOne.WP8.CS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Story.Text = CreateStory(); 
            
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String text = Story.Text;

            int nVowels = 0;
            int nNonWhiteSpace = 0;
            Object obj = new Object();

            ///THIS CODE DOES NOT COMPILE
            //var result = Parallel.ForEach(text,
            //                                             (ch) =>
            //                                             {
            //                                                 Char uCh = Char.ToUpper(ch);
            //                                                 if ("AEIOUY".IndexOf(uCh) >= 0)
            //                                                 {
            //                                                     lock (obj)
            //                                                     {
            //                                                         nVowels++;
            //                                                     }
            //                                                 }
            //                                                 if (!Char.IsWhiteSpace(uCh))
            //                                                 {
            //                                                     lock (obj)
            //                                                     {
            //                                                         nNonWhiteSpace++;
            //                                                     }
            //                                                 }
            //                                             });
            Results.Text = String.Format("Total characters:      {0,10:N0} {1}", text.Length, Environment.NewLine);
            Results.Text += String.Format("Total vowels:          {0,10:N0} {1}", nVowels, Environment.NewLine);
            Results.Text += String.Format("Total non-whitespace:  {0,10:N0} {1}", nNonWhiteSpace, Environment.NewLine);
        }

        private string CreateStory()
        {
            return @"One fine evening a young princess put on her bonnet and clogs, and went out to take a walk by herself in a wood; and when she came to a cool spring of water with a rose in the middle of it, she sat herself down to rest a while. Now she had a golden ball in her hand, which was her favourite plaything; and she was always tossing it up into the air, and catching it again as it fell.
     After a time she threw it up so high that she missed catching it as it fell; and the ball bounded away, and rolled along on the ground, until at last it fell down into the spring. The princess looked into the spring after her ball, but it was very deep, so deep that she could not see the bottom of it. She began to cry, and said, 'Alas! if I could only get my ball again, I would give all my fine clothes and jewels, and everything that I have in the world.'
     Whilst she was speaking, a frog put its head out of the water, and said, 'Princess, why do you weep so bitterly?'
     'Alas!' said she, 'what can you do for me, you nasty frog? My golden ball has fallen into the spring.'
     The frog said, 'I do not want your pearls, and jewels, and fine clothes; but if you will love me, and let me live with you and eat from off your golden plate, and sleep on your bed, I will bring you your ball again.'
     'What nonsense,' thought the princess, 'this silly frog is talking! He can never even get out of the spring to visit me, though he may be able to get my ball for me, and therefore I will tell him he shall have what he asks.'
     So she said to the frog, 'Well, if you will bring me my ball, I will do all you ask.'
     Then the frog put his head down, and dived deep under the water; and after a little while he came up again, with the ball in his mouth, and threw it on the edge of the spring.     
As soon as the young princess saw her ball, she ran to pick it up; and she was so overjoyed to have it in her hand again, that she never thought of the frog, but ran home with it as fast as she could.
     The frog called after her, 'Stay, princess, and take me with you as you said,'
     But she did not stop to hear a word.
     The next day, just as the princess had sat down to dinner, she heard a strange noise - tap, tap - plash, plash - as if something was coming up the marble staircase, and soon afterwards there was a gentle knock at the door, and a little voice cried out and said:
 

'Open the door, my princess dear, 
Open the door to thy true love here! 
And mind the words that thou and I said 
By the fountain cool, in the greenwood shade.'";

        }
    }
}