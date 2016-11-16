namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TagAttribute : ValidationAttribute
    {
        // Constructor
        public TagAttribute()
        {

        }

        // Method
        public override bool IsValid(object value)
        {
            string strValue = value as string;

            if (!string.IsNullOrEmpty(strValue))
            {
                var lenght = strValue.Length;

                if (lenght > 20)
                {
                    return false;
                }

                if (strValue[0] != '#')
                {
                    return false;
                }

                for (int i = 1; i < lenght; i++)
                {
                    if ((strValue[i] == ' ') || (strValue[i] == '#'))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}