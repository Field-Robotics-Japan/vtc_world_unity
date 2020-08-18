# vtc_world_unity
![vtc_world](.image/vtc_world.png)  
Virtual Tsukuba Challenge on Unity world data.  

[The Virtual Tsukuba Challenge (VTC) using Unreal Engine](https://github.com/furo-org/VTC) has been developed by [fuRo](https://www.furo.org/).

This repository is ONLY for the world (environment) data of VTC.  
If you may have interests including robot model, visit [vtc_unity](https://github.com/Field-Robotics-Japan/vtc_unity) repo, please.

If you have any Issues, or need bug tracking, visit [vtc_unity/issues](https://github.com/Field-Robotics-Japan/vtc_unity/issues) page, please.

# Installation
Thanks to [@ssilph](https://github.com/ssilph) from [#8](https://github.com/Field-Robotics-Japan/vtc_world_unity/issues/8)
### １．Installation of unity(2019.3.10f1)
First, install UnityHub with following links.
- Windows, Mac : https://unity3d.com/jp/get-unity/download
- Linux : http://kconcon3.hatenablog.com/entry/2019/06/27/220000

After that, choose and install Unity Editor (version : `2019.3.10f`) from archive.  
https://unity3d.com/get-unity/download/archive

### ２．Installation of Blender 2.8x
You need Blender>=2.8x. Plsease install with following commands (for Ubuntu).
```bash
$ sudo apt remove blender
$ sudo add-apt-repository ppa:thomas-schiex/blender
$ sudo apt update
$ sudo apt install blender
```
### ３．Installation of PointCloudViewer(version=2.8x) + bpy(version=2.8x)
You also need, PointCloudViewer and bpy.
First, download zip file from following link.
- https://github.com/uhlik/bpy#point-cloud-visualizer-for-blender-280  
Then, install them with following procedure.
- blender->Edit(Top Left)->Preferences->Add-ons(Left side)->install(Top Right)->choose zip file->install Add-on
Extract zip file

Install `space_view3d_point_cloud_visualizer.py` with same procedure.
- blender->Edit(Top Left)->Preferences->Add-ons(Left side)->install(Top Right)->choose space_view3d_point_cloud_visualizer.py file->install Add-on

### 4.Open vtc_world_unity
Finally, please open `vtc_world_unity` package from UnityHub. (It takes more than 5 minuites at the first time, in some case)

### Trouble Shooting
Some problems are come from `git lfs`
- If you have not installed `git lfs`, please install them. Then, `git clone` this repository again.
- If you already have installed `git lfs`, but have a problem. Try following procedure please.
```bash
$ git clean -fdx
$ git lfs pull
```

### From Unity Asset store
We utilize following Assets from Unity Asset Store.  
Every package are Free now (2020/05/13).
We partly modify and utilize those Assets.
- [Realistic Tree 9](https://assetstore.unity.com/packages/3d/vegetation/trees/realistic-tree-9-rainbow-tree-54622)
- [Mobile Tree Package](https://assetstore.unity.com/packages/3d/vegetation/trees/mobile-tree-package-18866)
- [Yughues Free Bushes](https://assetstore.unity.com/packages/3d/vegetation/plants/yughues-free-bushes-13168)
- [First Person All-in-One](https://assetstore.unity.com/packages/tools/input-management/first-person-all-in-one-135316)
- [Simple Cars Pack](https://assetstore.unity.com/packages/3d/vehicles/land/simple-cars-pack-97669)
- [Pcx](https://github.com/keijiro/Pcx)

# LICENSE Dependencies
- [Stencil2 PointCloud data](https://github.com/Field-Robotics-Japan/vtc_world_blender/blob/master/Resources/point_cloud/TsukubaChallenge_2018.ply) : [Apache2.0](http://www.apache.org/licenses/LICENSE-2.0
) by 防衛大学校ソフトウェア工学講座  
  This data is referenced to create the world model.
- [City Hall.fbx](https://github.com/furo-org/VTC/blob/TC2019/Assets/City%20Hall.fbx) : [Apache2.0](http://www.apache.org/licenses/LICENSE-2.0
) by [Tomoaki Yoshida](https://github.com/furo-org/VTC)  
  [CityHall.blend](./Assets/vtc_world_unity/Blender/Environment/CityHall/CityHall.blend) is modified from above FBX model.

# LICENSE
Copyright [2020] Ryodo Tanaka groadpg@gmail.com

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
