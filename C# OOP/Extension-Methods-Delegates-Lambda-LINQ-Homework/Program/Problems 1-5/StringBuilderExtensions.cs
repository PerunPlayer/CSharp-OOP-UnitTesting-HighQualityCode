namespace Program
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Sub(this StringBuilder builder, int index, int lenght)
        {
            string Appended = builder.ToString().Substring(index, lenght);
            builder.Clear().Append(Appended);

            return builder;
        }
    }
}