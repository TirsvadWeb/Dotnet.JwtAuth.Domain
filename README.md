﻿[![NuGet Downloads][nuget-shield]][nuget-url][![Contributors][contributors-shield]][contributors-url][![Forks][forks-shield]][forks-url][![Stargazers][stars-shield]][stars-url][![Issues][issues-shield]][issues-url][![License][license-shield]][license-url][![LinkedIn][linkedin-shield]][linkedin-url]

# ![Logo][Logo] TirsvadWeb JwtAuth Domain
This library is for TirsvadWeb.JwtAuth.

This library provides the domain logic for JWT authentication, including user management and validation.
It is designed to be used in conjunction with the TirsvadWeb framework.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
    - [NuGet Package](#nuget-package)
    - [Clone the repo](#clone-the-repo)
- [Contributing](#contributing)
- [Bug / Issue Reporting](#bug--issue-reporting)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)

## Features
- User registration and management
- JWT token generation and validation
- Integration with TirsvadWeb for secure API access

## Getting Started

### Prerequisites
- Dotnet 9.0 or later

### Installation
The TirsvadWeb.JwtAuth.Domain library can be installed in several ways:

#### NuGet Package
```
dotnet add package TirsvadWeb.JwtAuth.Domain
```
Then, run your package manager's install command to download and install the module.

#### Clone the repo
![Repo size][repos-size-shield]

```bash
git clone git@github.com:TirsvadWeb/Dotnet.JwtAuth.Domain.git
```

## 📂 Folder Structure
```Plaintext
Dotnet.JwtAuth.Domain/
├── 📄 docs                                  // Documentation files
│   └── 📄 doxygen                           // Doxygen output
├── 🖼️ images                                // Images used in documentation
├── 📂 src                                   // Source code for the library
│   └── 📦 TirsvadWeb.JwtAuth.Domain         // Main library folder
│       ├── 📦 Entities                      // Contains domain entities
│       └── 📦 Validation                    // Validation used in Models
└── 📂 tests                                 // Unit tests for the library
    └── 📦 TestEntityValidation              // Contains unit tests for entity validation

```

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

See [CONTRIBUTING.md](CONTRIBUTING.md)

## Bug / Issue Reporting  
If you encounter a bug or have an issue to report, please follow these steps:  

1. **Go to the Issues Page**  
  Navigate to the [GitHub Issues page][githubIssue-url].  

2. **Click "New Issue"**  
  Click the green **"New Issue"** button to create a new issue.  

3. **Provide Details**  
  - **Title**: Write a concise and descriptive title for the issue.  
  - **Description**: Include the following details:  
    - Steps to reproduce the issue.  
    - Expected behavior.  
    - Actual behavior.  
    - Environment details (e.g., OS, .NET version, etc.).  
  - **Attachments**: Add screenshots, logs, or any other relevant files if applicable.  

4. **Submit the Issue**  
  Once all details are filled in, click **"Submit new issue"** to report it.  

## License
Distributed under the GPL-3.0 [License][license-url].

## Contact
Jens Tirsvad Nielsen - [LinkedIn][linkedin-url]

## Acknowledgments
<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badge
[contributors-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badge
[forks-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/network/members
[stars-shield]: https://img.shields.io/github/stars/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badge
[stars-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/stargazers
[issues-shield]: https://img.shields.io/github/issues/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badge
[issues-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/issues
[license-shield]: https://img.shields.io/github/license/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badge
[license-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/
[githubIssue-url]: https://github.com/TirsvadWeb/Dotnet.JwtAuth.Domain/issues/
[repos-size-shield]: https://img.shields.io/github/repo-size/TirsvadWeb/Dotnet.JwtAuth.Domain?style=for-the-badg

[logo]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.JwtAuth.Domain/master/images/logo/32x32/logo.png

<!-- If this is a Nuget package -->
[nuget-shield]: https://img.shields.io/nuget/dt/TirsvadWeb.JwtAuth.Domain?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/TirsvadWeb.JwtAuth.Domain/
