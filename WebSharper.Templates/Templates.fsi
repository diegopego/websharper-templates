﻿// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2014 IntelliFactory
//
// GNU Affero General Public License Usage
// WebSharper is free software: you can redistribute it and/or modify it under
// the terms of the GNU Affero General Public License, version 3, as published
// by the Free Software Foundation.
//
// WebSharper is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License
// for more details at <http://www.gnu.org/licenses/>.
//
// If you are unsure which license is appropriate for your use, please contact
// IntelliFactory at http://intellifactory.com/contact.
//
// $end{copyright}

namespace WebSharper.Templates

open System
open System.IO

/// Options for initializing templates.
type InitOptions =
    {
        /// Directory that gets created and/or populated.
        Directory : string

        /// The name of the project to create.
        ProjectName : string

        /// The WebSharper.Templates nuget package.
        TemplatesPackage: byte[]
    }

/// Represents a WebSharper MSBuild/XBuild template.
[<Sealed>]
type Template =

    /// Initializes a new instance of the template.
    member Init : InitOptions -> unit

    /// All templates.
    static member All : list<Template>

    /// The bundle-website template.
    static member BundleWebsite : Template

    /// The extension template.
    static member Extension : Template

    /// The library template.
    static member Library : Template

    /// The sitelets-host template.
    static member SiteletsHost : Template

    /// The sitelets-html template.
    static member SiteletsHtml : Template

    /// The sitelets-website template.
    static member SiteletsWebsite : Template

    /// The owin-selfhost template.
    static member OwinSelfHost : Template

    /// The bundle-uinext template.
    static member BundleUINext : Template

    /// The sitelets-uinext template.
    static member SiteletsUINext : Template

