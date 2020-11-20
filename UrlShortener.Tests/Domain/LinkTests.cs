using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Common;
using UrlShortener.Domain;
using Xunit;

namespace UrlShortener.Tests.Domain
{
    public class LinkTests
    {
        [Fact]
        public void Should_Compute_shortented_url()
        {
            string url = "https://google.com/test";

            var link = new Link();
            link.URL = url;

            var hashedUrl = Hash.GetSha256Hash(url);
            var base64 = Convert.ToBase64String(hashedUrl);
            var expected = base64.Substring(0, 6);

            var result = link.ComputeShortenedUrl();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_url_should_compute_nothing()
        {
            var link = new Link();
            var expected = string.Empty;

            var result = link.ComputeShortenedUrl();

            Assert.Equal(expected, result);
        }
    }
}
