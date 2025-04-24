# ComfileTech.ComfilePi.CP_IO13_4C.Demo

This is a .NET Framework Winforms application to demonstrate features of the [CP-IO13-4C](https://comfiletech.com/raspberry-pi-panel-pc/cp-io13-4c-i-o-board-accessory-for-cpi-c-series/) IO board for the [ComfilePi industrial touchscreen panel PCs](https://comfiletech.com/linux-panel-pc/), and how to program it.

Execution on a ComfilePi panel PC requires [Mono](https://gitlab.winehq.org/mono/mono), which should already be installed by default on the ComfilePi panel PCs.

This application uses the following .NET libraries to control the digital inputs and outputs on the CP-IO13-4C board.
* [System.Device.Gpio](https://www.nuget.org/packages/System.Device.Gpio/)

Although the `ComfileTech.ComfilePi.CP_IO13_4C.Demo` project is a .NET Framework Winforms application, the `ComfileTech.ComfilePi.CP_IO13_4C` project is a .NET Standard library, so it can also be used in more recent .NET applications.

## Deploying to and Debugging on a ComfilePi Panel PC

Install COMFILE Technology's [Remote Mono Debugger Visual Studio extension](http://www.comfilewiki.co.kr/en/doku.php?id=comfilepi:running_.net_winforms_applications_with_mono:remote_mono_debugger:index#ssh_authentication), and then edit the `ComfilePi` launch profile to deploy the application to and debug it on a ComfilePi from within Visual Studio.

