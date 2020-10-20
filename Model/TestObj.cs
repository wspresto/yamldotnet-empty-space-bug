using System;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
namespace empty_space_bug {
  public class TestObj {
      [YamlMember(ScalarStyle = ScalarStyle.Literal)]
      public string Testing { get; set; }
  }
}