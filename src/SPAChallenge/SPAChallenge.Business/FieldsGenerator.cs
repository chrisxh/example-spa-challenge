namespace SPAChallenge.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SPAChallenge.Business.Persistence;

    public class FieldsGenerator
    {
        private const int minString = 5;
        private const int maxString = 14;
        private const int maxStatus = 3;
        private const int minFields = 10;
        private const int maxFields = 20;
        private readonly Random RandomGenerator;
        public FieldsGenerator()
        {
            RandomGenerator = new Random();
        }
        public List<Field> Generate()
        {
            var fields = new List<Field>();
            int amountFields = RandomGenerator.Next(minFields, maxFields + 1);
            for (int i = 0; i < amountFields; i++)
            {
                fields.Add(GenerateField());
            }
            return fields;
        }


        private string GetRandomString(int maxLength)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(
                Enumerable.Repeat(chars, maxLength)
                          .Select(s => s[RandomGenerator.Next(s.Length)])
                          .ToArray());
        }

        private Field GenerateField()
        {
            var caption = GetRandomString(RandomGenerator.Next(minString, maxString));
            return new Field()
                   {
                       Name = string.Format("_{0}", caption),
                       Caption = caption,
                       Status = (Status)(RandomGenerator.Next(maxStatus)),
                       Tooltip = "Enter transaction number",
                       LastUpdate = DateTime.Now
                   };
        }
    }
}
