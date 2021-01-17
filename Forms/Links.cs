using System;

namespace Exercise.Forms
{
    public class Links
    {
        public Links(Uri url)
        {
            Url = url;
        }

        public Uri Url { get; }
    }
}
