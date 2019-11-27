<p align="center">
<img
    src="https://avatars2.githubusercontent.com/u/34855698?s=460&v=4" width="250px">
</p>

<p align="center">      
  <a href="https://travis-ci.org/camchain/cam-server">
    <img src="https://travis-ci.org/camchain/cam-server.svg?branch=master">
  </a>
  <a href="https://github.com/camchain/cam-server/blob/master/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg">
  </a>

</p>

## Prerequisites

You will need Window, Linux or macOS. Ubuntu 14 and 16 are supported. Ubuntu 17 is not supported.

Install [.NET Core](https://www.microsoft.com/net/download/core).

On Linux, install the LevelDB and SQLite3 dev packages. E.g. on Ubuntu:

```sh
sudo apt-get install libleveldb-dev sqlite3 libsqlite3-dev libunwind8-dev
```

On macOS, install the LevelDB package. E.g. install via Homebrew:

```
brew install --ignore-dependencies --build-from-source leveldb
```

On Windows, use the [Cam version of LevelDB](https://github.com/camchain/leveldb).

## Download pre-compiled binaries

See also [official docs](http://docs.camatrix.org/en-us/node/introduction.html). Download and unzip [latest release](https://github.com/camchain/cam-server/releases).

```sh
dotnet cam-server.dll
```

## Compile from source

Clone the cam-server repository.

```sh
cd cam-server
dotnet restore
dotnet publish -c Release
```
In order to run, you need .NET Core. Download the SDK [binary](https://www.microsoft.com/net/download/linux).

Assuming you extracted .NET in the parent folder:

```sh
../dotnet bin/Release/netcoreapp2.0/cam-server.dll .
```

## Logging

To enable logs in cam-server, you need to add the ApplicationLogs plugin. Please check [here](https://github.com/camchain/Cam-plugins) for more information.


## Bootstrapping the network.
In order to synchronize the network faster, please check [here](http://docs.camatrix.org/en-us/network/syncblocks.html).


## Usage

See [documentation](https://docs.camatrix.org/en-us/node/cli/cli.html). E.g. try `show state` or `create wallet wallet.json`.
