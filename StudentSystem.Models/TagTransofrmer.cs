namespace StudentSystem.Models
{
    using System.Text;

    public static class TagTransofrmer
    {
        public static string Transform(string input)
        {
            string tag = input.Trim(' ');
            StringBuilder finishedTag = new StringBuilder();

            for (int i = 0; i < tag.Length; i++)
            {
                if (i != 0)
                {
                    if ((tag[i] != ' ') && (tag[i] != '#'))
                    {
                        finishedTag.Append($"{tag[i]}");
                    }
                }
                else
                {
                    if (tag[i] == '#')
                    {
                        finishedTag.Append("#");
                    }
                    else
                    {
                        finishedTag.Append($"#{tag[i]}");
                    }
                }
            }
            if (finishedTag.Length > 20)
            {
                finishedTag.Remove(20, finishedTag.Length - 20);
            }
            
            return finishedTag.ToString();
        }
    }
}