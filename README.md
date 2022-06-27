# Interview test
----------------

## Environment & Dependencies:
This project requires unity and node installed, preferably:
* [Unity](https://unity3d.com/get-unity/download/archive) 2021.3.5f1 
* [Node.js](https://nodejs.org) 16.15.1.

---------------------

## How to start the project:
* To clone the repository use:
    * if your are using Git 1.6.5 version or higher:
```git clone --recursive https://github.com/miguelangelgil/LabCaveUnitySide.git ```
    * otherwise use this command:
```git clone https://github.com/miguelangelgil/LabCaveUnitySide.git && git submodule init && git submodule update```
* Once you have downloaded the project, go to the path  ```LabCaveUnitySide\Server\LabCaveTest``` and open a terminal, type the following commands:
    * ```npm install```
    * ```npm start```
* Once the server is started, in unity hub add the project which is in ```LabCaveUnitySide\LabCaveTest```
* Finally open the only scene inside the Scenes folder 

-----------------

## Unity Structure:
* Assets
    * Prefab
        * PanelTime 
    * Scenes
        * mainScene
    * Scripts
        * PanelTimeManager
        * RequestServer

------------------

## Licenses:

MIT License

Copyright (c) 2022 MAGMa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

