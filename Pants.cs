using System;
using System.Collections.Generic;
using System.Text;

namespace PantsBarn
{
    public class Pants
    {
        private string style;

        private List<int> sizes;

        public Pants(string style, List<int> sizes)
        {
            this.style = style;
            this.sizes = sizes;
        }

        public string GetStyle()
        {
            return style;
        }

        public bool IsAvailable(int size)
        {
            if (sizes.Contains(size))
            {
                return true;
            }

            return false;
        }

		public override string ToString()
		{
            string sizeString = "";
            foreach(int size in sizes)
			{
                sizeString = sizeString + size + " ";
			}

            return "Style: " + style + ", Sizes: " + sizeString;
		}
	}
}
