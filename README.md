# BaseWeedPlugin

Requires bepinex on unity game: https://docs.bepinex.dev/articles/user_guide/installation/index.html   
 
This is a base mod source code that you can compile using visual studio and then use that .dll to make yo own mod  

This is going to be a rough start of a guide, but atleast if you are savvy enough to learn Unity and Bepinex, of course that C#. Then you will be able to getting     moddin on the way by just lookin a the source code !   

Few things this mod does an example:  
: Gets the player gameobject and interacts with it by making its local scale Y bigger (LeftControl enables / RightControl disables)  
: Patches the bootPC where it doesn't load at all   
: Pressing the Down Arrow key, will create a canvas element that says "TEST" woot  
: Number 8 on the keyboard will load an empty weed terrain scene, perfect for testing.  


!!! Dependencies::

I put them in a folder up one in ..\libs\ referencing is important for compile, this is obtainable from the  \Weed Shop 3\Weed Shop 3_Data\Managed  
Adjust .csproj to your liking / visual studio references, to match until success. This is the section of .csproj you need to adjust or modify it in the visual studio   right click context menu on dependencies!!!   
```
  <ItemGroup>
    <Reference Include="0Harmony">
      <HintPath>..\libs\0Harmony.dll</HintPath>
    </Reference>
    <Reference Include="Assembly-CSharp">
      <HintPath>..\libs\Assembly-CSharp.dll</HintPath>
    </Reference>
    <Reference Include="BepInEx">
      <HintPath>..\libs\BepInEx.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine">
      <HintPath>..\libs\UnityEngine.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine.CoreModule">
      <HintPath>..\libs\UnityEngine.CoreModule.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine.InputLegacyModule">
      <HintPath>..\libs\UnityEngine.InputLegacyModule.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine.TextRenderingModule">
      <HintPath>..\libs\UnityEngine.TextRenderingModule.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine.UI">
      <HintPath>..\libs\UnityEngine.UI.dll</HintPath>
    </Reference>
    <Reference Include="UnityEngine.UIModule">
      <HintPath>..\libs\UnityEngine.UIModule.dll</HintPath>
    </Reference>
  </ItemGroup>
```
