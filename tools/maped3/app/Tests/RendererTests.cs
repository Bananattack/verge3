using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using winmaped2.code;

namespace winmaped2.Tests {
    [TestFixture]
    public class RendererTests {
        [Test]
        public void TestDrawImage() {
            int[] pixels = new int[16 * 16];
            for (int i = 0; i < pixels.Length; i++) {
                pixels[i] = 1;
            }
            Image img = new Image(pixels);

            pr2.Render.Image destImage = pr2.Render.Image.create(16, 16);
            Renderer ren = new Renderer(destImage);

            ren.drawImage(img, 0, 0, true);

            int[] resultPixels = ren.BackBuffer.getArray();
            Assert.AreEqual(pixels, resultPixels);
        }
    }
}
