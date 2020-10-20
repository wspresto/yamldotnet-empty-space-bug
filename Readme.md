# Testing YamlDotNet Space Character Issue
This small project illustrates how a slightly modified scalar block literal with space characters immediately before a line break will break the serialization.

## What?
When we are serializing a scalar block literal using YamlDotNet and we encounter a special case (still valid yaml), the library forces the style to default to double quoted style.


## How?
There are 3 provided scenarios in the ./input folder of this project. One is a control that shows a block literal scalar type "Testing: |-", no-spaces-before-line-break.yml .
This file deserializes and serializes correctly.

2 of these scenarios, spaces-before-line-break.yml and more-spaces-before-line-break.yml, do no deserialize / serialize correctly.
These files both have at least a single ' ' character before a line break either /n or /r/n. It does not matter.


## Running the Test
This is a .Net Core application.

```
  dotnet run
```

Observe the results in the ./output folder.
