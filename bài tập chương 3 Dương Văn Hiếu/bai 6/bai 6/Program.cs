using System;
namespace bai6
{
    class String
    {
        public string value; {  get; set; }
        public String(string str)
        { value = str; }
    }
    public static bool operator ==(String str1, String str2)
    {
        return str1.value == str2.value;
    }
    public static bool operator != ( String str1, String str2)
    {
        return str1.value != str2.value;
    }
    public static bool operator > (String str1, String str2)
    {
        return str1.value > str2.value;
    }
    public static bool operator >= (String str1, String str2)
    {
        return str1.value >= str2.value;
    }
}