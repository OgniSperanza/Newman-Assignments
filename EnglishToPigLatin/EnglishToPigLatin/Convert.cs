//Jacob Barnes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishToPigLatin
{
    class Convert
    {
        //Private variables
        private string strPigLatin = "";
        private int i = 0;

        public Convert(string english)//Convert English to Pig Latin
        {
            try
            {
                //Variables
                string strEnglish = english;
                string[] strWordsToConvert = strEnglish.Split();
                string strFirstLetter = "";
                string strConsonants = "";
                string strRemaining;
                int index;
                string strVowels = "AEIOUaeiou";
                                
                foreach (string word in strWordsToConvert)
                {

                    strFirstLetter = word.Substring(0, 1);//First letter of word to be converted
                    index = strVowels.IndexOf(strFirstLetter);//Check if first letter is a vowel

                    if (strFirstLetter == strFirstLetter.ToUpper())//If fist letter is capitalized then...
                    {
                        switch (index)
                        {
                            case -1:
                                if (strFirstLetter.ToUpper() == "Q")//If the first letter is a q or Q then...
                                {
                                    strFirstLetter = word.Substring(i, 2);
                                    strRemaining = word.Substring(2);
                                    StringBuilder Capitalization = new StringBuilder(strRemaining);
                                    Capitalization[0] = char.ToUpper(Capitalization[0]);
                                    strPigLatin += Capitalization + strFirstLetter.ToLower() + "ay" + " ";
                                }//End if
                                else//Else if it is not a q or Q then...
                                {
                                    while (index == -1)//While the first letter is not a vowel
                                    {
                                        i++;
                                        strFirstLetter = word.Substring(i, 1);
                                        if (strFirstLetter.ToUpper() == "Y")//If next letter is a y or Y then...
                                        {
                                            index = 0 + i;
                                        }//End if
                                        else//Else if it is not a y or Y then...
                                        {
                                            index = strVowels.IndexOf(strFirstLetter);
                                        }//End else
                                    }//End while

                                    strRemaining = word.Substring(i, word.Length - i);
                                    strConsonants = word.Substring(0, i);
                                    StringBuilder Capitalization = new StringBuilder(strRemaining);
                                    Capitalization[0] = char.ToUpper(Capitalization[0]);
                                    strPigLatin += Capitalization + strConsonants.ToLower() + "ay" + " ";
                                }//End else
                                break;
                            default://If the first letter is a vowel then...
                                strPigLatin += word + "way" + " ";
                                break;
                        }//End switch
                        i = 0;//Reset i for next word in strWordsToConvert            
                    }
                    else//Else if the first letter is not capitalized then...
                    {
                        switch (index)
                        {
                            case -1:
                                if (strFirstLetter.ToUpper() == "Q")//If the first letter is a q or Q then...
                                {
                                    strFirstLetter = word.Substring(i, 2);
                                    strRemaining = word.Substring(2);
                                    strPigLatin += strRemaining + strFirstLetter.ToLower() + "ay" + " ";
                                }//End if
                                else//Else if it is not a q or Q then...
                                {
                                    while (index == -1)//While the first letter is not a vowel
                                    {
                                        i++;
                                        strFirstLetter = word.Substring(i, 1);
                                        if (strFirstLetter.ToUpper() == "Y")//If next letter is a y or Y then...
                                        {
                                            index = 0 + i;
                                        }//End if
                                        else//Else if it is not a y or Y then...
                                        {
                                            index = strVowels.IndexOf(strFirstLetter);
                                        }//End else
                                    }//End while

                                    strRemaining = word.Substring(i, word.Length - i);
                                    strConsonants = word.Substring(0, i);
                                    strPigLatin += strRemaining + strConsonants.ToLower() + "ay" + " ";
                                }//End else
                                break;
                            default://If the first letter is a vowel then...
                                strPigLatin += word + "way" + " ";
                                break;
                        }//End switch

                        i = 0;//Reset i for next word in strWordsToConvert            
                    }//End else
                }//End foreach
            }//End try
            catch (Exception)
            {
                MessageBox.Show("There is an input error. Please examine data entered" + "\n", "Error", MessageBoxButtons.OK);
            }
        }//End Convert
        
        //Properties
        public string Piglatin
        {
            get{return strPigLatin;}   
        }
    }
}
