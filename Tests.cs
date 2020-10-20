
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using System.IO;
namespace empty_space_bug
{
    class Tests {
      public void TestNoSpacesBeforeLineBreak() {
        DeserializeThenSerialize("no-spaces-before-line-break.yml");
      }  

      public void TestSpaceBeforeLineBreak() {
        DeserializeThenSerialize("spaces-before-line-break.yml");
      }  

      public void TestMoreSpacesBeforeLineBreak() {
        DeserializeThenSerialize("more-spaces-before-line-break.yml");
      }              

      void DeserializeThenSerialize(string filename) {
        var d = new Deserializer();
        var s = new Serializer();
        var file = File.ReadAllText($"./input/{filename}");
        var obj = d.Deserialize<TestObj>(file);
        var yml = s.Serialize(obj);
        File.WriteAllText($"./output/{filename}", yml);
      }    
    }
}
