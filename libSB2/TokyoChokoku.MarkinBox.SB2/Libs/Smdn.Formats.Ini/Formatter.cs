// 
// Author:
//       smdn <smdn@smdn.jp>
// 
// Copyright (c) 2008-2014 smdn
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;

namespace Smdn.Formats.Ini {
  internal static class Formatter {
    // TODO: コメント、記述順を維持した上書き
    public static void Format(IniDocument document, TextWriter writer)
    {
      var sections = new List<IniSection>(document.Sections);

      // format default section
      var defaultSection = sections.Find(delegate(IniSection s) {
        return (string.Empty.Equals(s.Name));
      });

      if (defaultSection != null) {
        FormatEntries(defaultSection, writer);
        sections.Remove(defaultSection);
      }

      // format other sections
      foreach (var section in sections) {
        FormatSection(section, writer);
        FormatEntries(section, writer);
      }
    }
    
    private static void FormatSection(IniSection section, TextWriter writer)
    {
      writer.WriteLine("[{0}]", section.Name);
    }

    private static void FormatEntries(IniSection section, TextWriter writer)
    {
      foreach (KeyValuePair<string, string> entry in section) {
        writer.WriteLine("{0}={1}", entry.Key, entry.Value);
      }

      writer.WriteLine();
    }
  }
}