# Technotes

<!-- TOC -->
1. [Introduction](#introduction)
2. [Requirements](#requirements)
3. [Building Instructions](#building-instructions)
<!-- /TOC -->

<a name="introduction"/></a>
## Introduction

This repository contains technical resources for developers such as technical notes,
source code, tutorials, and much more.

<a name="requirementss"></a>
## Requirements

Building the diverse resources in this repository requires the following software to be
present on your system:

* [Ruby](https://www.ruby-lang.org): Ruby Distribution
* [Asciidoctor](https://asciidoctor.org): Text Processor and Publishing Toolchain
* [mklib](https://github.com/tiletoons/mklib): Default Configuration and Predefined Targets for Make
* [Visual Studio](https://visualstudio.microsoft.com/vs): .NET Integrated Development Environment

<a name="building-instructions"></a>
## Building Instructions

For the complete list of supported targets, issue the following command from the
project's top directory:

```sh
make help
```

To build a technote in all the supported formats together with any associated resource
like an example application, issue the following command:

```sh
make
```

---

*Copyright 2021 Tiletoons! Inc.*
