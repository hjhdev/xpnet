#
# Makefile
#
# Targets:
#   plugin  - Creates a 'plugin' folder with all of the native and DLLs collected,
#             ready to install by hand into X-Plane.
#   package - Creates a 'package' folder with .nupkg files ready to publish to
#             nuget.org or another gallery.
#
# There are the following packages:
#  XPNet.CLR            - The .NET assembly that you reference to write your plugin code.
#  XPNet.Native.macOS   - Built macOS binary.
#  XPNet.Native.Windows - Built Windows binary.
#  XPNet.CLR.Template   - The starter project, for use with 'dotnet new'
#
# For deployment to nuget, the policy is to always deploy all packages at the same time
# (within a reasonable number of minutes of each other), with matched versions.  That
# way, if you have XPNet.CLR v1.2, and XPNet.Native.* v1.2, you know they all match.
#
# Before you upload new packages, be sure to update the package version numbers in the
# various .nuspec files to all match.
#
# The 'package' target will build as many of the packages as can be built on the current
# OS.  To do a full deploy to nuget, you have to build and deploy the non-native packages
# on whatever OS is convenient, and each native package on the OS for that package.
# (We're not set up to do any cross-compiling).  Upload them all to nuget.
#
# The packages for non-Windows platforms can be built from this Makefile.  To build the
# package for the Windows platform, open the SLN file in Visual Studio, build XPNet.Native
# in x64/Release and x32/Release (you must build both; the package includes both), then
# run this from the XPNet.Native folder:
#
# dotnet pack -c Release XPNet.Native.NuSpec.win.csproj
#
# The output nupkg will end up in bin\x64\Release.  I don't know why; it's not x64-specific
# in any way.  You can probably improve this with edits to XPNet.Native.NuSpec.win.csproj.
#
# For safety purposes, and because you need the key to deploy the packages anyway,
# (which is not included in this repository) this Makefile does not actually deploy
# packages to nuget.  To deploy to nuget.org once you've got them, you'll run a command
# like this, once for each package:
#
# dotnet nuget push packages/XPNet.CLR.1.2.0.nupkg -k <the_api_key>
#
# (Or login on nuget.org and just drag+drop the new .nupkg files on the Upload page.)
#

#######################################################################################3

Configuration   =Release
Platform        =netcoreapp2.1

OutDir          =plugin
PakDir          =package

#######################################################################################3

RM             :=rm -f
MKDIR          :=mkdir -p
CP             :=cp

#######################################################################################3

all: plugin package

clean:
	$(RM) -r XPNet.CLR/obj XPNet.CLR/bin
	$(RM) -r XPNet.LoggerPlugin/obj XPNet.LoggerPlugin/bin
	$(RM) -r XPNet.CLR.Template/obj XPNet.CLR.Template/bin
	$(RM) -r $(OutDir)
	$(RM) -r $(PakDir)
	cd XPNet.Native && $(MAKE) clean

xpnetclr:
	cd XPNet.CLR && dotnet build -c $(Configuration) && dotnet publish -c $(Configuration) && dotnet pack -c $(Configuration)


template:
	cd XPNet.CLR.Template && nuget pack XPNet.CLR.Template.nuspec -OutputDirectory ../package


loggerplugin:
	cd XPNet.LoggerPlugin && dotnet build -c $(Configuration) && dotnet publish -c $(Configuration)


native:
	cd XPNet.Native && $(MAKE)


prepare_plugin:
	$(MKDIR) $(OutDir)


prepare_package:
	$(MKDIR) $(PakDir)


builds: xpnetclr loggerplugin native


plugin: prepare_plugin builds
	$(CP) XPNet.Native/lib/*.xpl $(OutDir)
	$(CP) XPNet.CLR/bin/$(Configuration)/$(Platform)/publish/*.dll $(OutDir)
	$(CP) XPNet.LoggerPlugin/bin/$(Configuration)/$(Platform)/publish/*.dll $(OutDir)


package: prepare_package builds template
	$(CP) XPNet.Native/bin/$(Configuration)/*.nupkg $(PakDir)
	$(CP) XPNet.CLR/bin/$(Configuration)/*.nupkg $(PakDir)

