  @EcHo off

set /p jm="Enter map name: "

copy *.jm Json2wmap\bin\Debug

Json2wmap\bin\Debug\Json2wmap *.jm %jm%.wmap

echo wmap successfully compiled.
echo Moving the Wmap to Json2WmapMaps folder
move %jm%.wmap Json2WmapMaps
echo Moved the Wmap to Json2WmapMaps folder
pause