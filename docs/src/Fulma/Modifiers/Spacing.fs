module Modifiers.Spacing

open Fable.React
open Fable.React.Props
open Fulma
open Fulma.Extensions.Wikiki

let paragraphSpacing() =
    // Define helpers to get intellisense
    let isCustomLightBlue = IsCustomColor "custom-light-blue"
    let isCustomPurple = IsCustomColor "custom-purple"
    // Demo
    div [ ]
        [ Text.p [ Modifiers [ Modifier.Spacing (Spacing.MarginLeftAndRight, Spacing.Is4) ] ]
                 [ str "Left and right margins of 4" ]
          Text.p [ Modifiers [ Modifier.Spacing (Spacing.PaddingBottom, Spacing.Is2) ] ]
                 [ str "Bottom padding of 2" ]
          Text.p [ Modifiers [ Modifier.Spacing (Spacing.PaddingTopAndBottom, Spacing.Is3) ] ]
                 [ str "Top and bottom padding of 3"]
        ]

let view =
    Render.docPage [
        Render.contentFromMarkdown
            """
# Modifiers - Spacing helpers

## Spacing

Change the size and color of the text for one or multiple viewport width.  It allows you to combine a margin/padding with a direction and an amount.

__NOTE:__ This does not appear to affect `Text.Span` elements, but does work with `Text.p` and `Text.div` elements.

*[Bulma documentation](https://bulma.io/documentation/helpers/spacing-helpers/)*

<table>
    <tbody>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mr-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginRight, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pr-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingRight, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mb-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginBottom, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pb-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingBottom, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white ml-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginLeft, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pl-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingLeft, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mx-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginLeftAndRight, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white px-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingLeftAndRight, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white my-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTopAndBottom, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white py-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTopAndBottom, Spacing.Is2)</code>
            </td>
        </tr>
    </tbody>
</table>

## Spacing sizes

<table>
    <tbody>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-0">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is0)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-0">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is0)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-1">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is1)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-1">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is1)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is2)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-2">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is2)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-3">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is3)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-3">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is3)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-4">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is4)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-4">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is4)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-5">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is5)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-5">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is5)</code>
            </td>
        </tr>
        <tr>
            <td>
                <div class="has-background-black has-text-white mt-6">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.MarginTop, Spacing.Is6)</code>
            </td>
            <td>
                <div class="has-background-black has-text-white pt-6">text</div>
            </td>
            <td>
                <code>Modifier.Spacing (Spacing.PaddingTop, Spacing.Is6)</code>
            </td>
        </tr>
    </tbody>
</table>
            """

        Render.docSection
            """### Demo"""
            (Widgets.Showcase.view paragraphSpacing (Render.includeCode __LINE__ __SOURCE_FILE__)) ]
