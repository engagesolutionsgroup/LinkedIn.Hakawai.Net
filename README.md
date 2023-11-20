## [Linked.Hakawai](https://github.com/linkedin/Hakawai) .NET-iOS Binding Library 
[![NuGet version (LinkedIn.Hakawai)](https://img.shields.io/nuget/v/LinkedIn.Hakawai.svg?style=flat-square)](https://www.nuget.org/packages/LinkedIn.Hakawai/)
## Hakawai

A subclass of `UITextView` providing extended functionality and support for 'plugins'. Hakawai ships with the `Mentions` plug-in, which provides a powerful and flexible way to easily add social-media-esque @mentions-style annotation support to your iOS app.

*For a higher-level overview, check out our [blog post](http://engineering.linkedin.com/ios/introducing-hakawai-powerful-mentions-enabled-text-view-ios) at the LinkedIn engineering blog.*


## :sparkles: Features

- A convenient **drop-in replacement** for ``UITextView`` instances
  - Includes Storyboards and XIBs
- Easily modify **add, remove, and transform** the text view's plain and attributed text using a set of powerful block-based APIs
- Work with attribute formatting and easily register or unregister **custom attributes** with enhanced attribute APIs
- Easily add, remove, and manage **accessory views**
  - These UI elements can be added/removed from the text view for additional functionality
- **Lock the current line of text** to the top or the bottom of the text view using single-line viewport mode
- Programmatically **dismiss autocorrect suggestions**, and temporarily override the autocorrect, autocorrection, and spell checking modes
- Solve several `UITextView` text layout bugs as Hakawai implements a **custom layout manager and text container**
- **Extend functionality** by registering or unregistering plugins
- *EXPERIMENTAL* - Easily **monitor user changes** to the text view's contents using the optional Abstraction Layer
    - Two-stage insertion for Chinese and Japanese keyboards is also properly handled
    - Abstraction Layer is built into the text view
    - Can also be pulled out and used independently if you desire


For full information see https://github.com/linkedin/Hakawai