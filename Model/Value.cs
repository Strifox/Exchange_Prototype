using System.ComponentModel;

namespace Models
{
    public class Value
    {
        public string Name { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// Sets the name and description of the value
        /// </summary>
        /// <param name="name">Shortening of value, e.g "USD"</param>
        /// <param name="text">Description of the value, e.g "American Dollar"</param>
        public Value(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }
}
