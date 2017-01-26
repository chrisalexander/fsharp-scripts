# Football walkthrough

## Source

Original series of blog posts:

- [Getting started with F# scripting](http://chris-alexander.co.uk/on-engineering/f-sharp/getting-started-with-f-sharp-scripting/)
- [Experimenting with data in F#](http://chris-alexander.co.uk/on-engineering/f-sharp/experimenting-with-data-in-f-sharp/)
- [Visualising data in F#](http://chris-alexander.co.uk/on-engineering/f-sharp/visualising-data-in-f-sharp/)

## Getting started

### VS Code

- Text editor with plugins (see Atom)
- Ionide plugins - [ionide.io](http://ionide.io/)
- Create a directory for your code and open it up

### Creating an F# script

- New file, saved as .fsx
- FSI
- Alt+Enter: Evaluate current selection
- Alt+/: Evaluate current line

## Getting data

### FSLab

- Collection of F# tools brought together for convenient consumption.
- [fslab.org](https://fslab.org/)
- [Analysing data with F#](http://www.oreilly.com/programming/free/analyzing-visualizing-data-f-sharp.csp) report from O'Reilly
- Loading in the library

### Introduction to type providers

- This is a bit of black magic
- Dynamically created types
- Create type provider
- Load data into types

### Using the data

- Collecting together the matches from the rounds

## Visualising the data

### XPlot library

- [XPlot](https://tahahachana.github.io/XPlot/)
- Supports Google Charts API and Plot.ly
- Other ones are available in FSLab including native rendering on Windows
- How to load the library from FSLab

### Data formatting

- Basic formatting as earlier
- Creating data pairs
-- Flip
-- OrZero and option types
--- Alternative implementation to OrZero using match
---- Invoke with OrZero (Some 5) and OrZero None - note brackets required
-- CreateDataPair
- Map across all matches

### Rendering

- Render with Chart.Scatter