# MassHexEditor

A program to help with hexadecimal editing, specifically with trial and error on specific offsets and individual values. Helpful for ROM hacking and research.

## Usage

(You can provide the program with a custom output folder, otherwise, it will output files to the root of the drive.)

Use a program like [HxD](https://mh-nexus.de/en/hxd/) to make viewing the hex values easier.

- Provide the program a specific file you want to edit.
- Input the hex offset you wish to adjust.
- Give a range of valid hexadecimal values and it will generate N amount of files based on how many values are in the range.
- It will generate all the files with the given offset and individual value in the file name for easy viewing.
