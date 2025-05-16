/* Á simple program that print the given string in upword and downword direction
 * adding one char at the end and at the end of the string print the whole string and voice versa*/
string str = "Denmark";
string upwordstring = "";




for(int i = 0; i < str.Length; i++)
{
    upwordstring += str[i];
    Console.WriteLine(upwordstring);
   
    
}
for(int j=str.Length-1; j>=0; j--)
{
   string downstring1 = str.Substring(0,j);

  Console.WriteLine(downstring1);
    
}