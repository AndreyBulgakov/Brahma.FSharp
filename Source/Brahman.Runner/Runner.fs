﻿module Brahman.Runner

let first = [|
    [|0x00uy; 0x00uy; 0x00uy; 0x14uy; 0x66uy; 0x74uy; 0x79uy; 0x70uy; 0x69uy; 0x73uy; 0x6Fuy; 0x6Duy|];//MP4
    [|0x00uy; 0x00uy; 0x00uy; 0x18uy; 0x66uy; 0x74uy; 0x79uy; 0x70uy; 0x33uy; 0x67uy; 0x70uy; 0x35uy|];//MP4
    [|0x00uy; 0x00uy; 0x00uy; 0x1Cuy; 0x66uy; 0x74uy; 0x79uy; 0x70uy; 0x4Duy; 0x53uy; 0x4Euy; 0x56uy; 0x01uy; 0x29uy; 0x00uy; 0x46uy; 0x4Duy; 0x53uy; 0x4Euy; 0x56uy; 0x6Duy; 0x70uy; 0x34uy; 0x32uy|];//MP4
    [|0x1Auy; 0x45uy; 0xDFuy; 0xA3uy; 0x93uy; 0x42uy; 0x82uy; 0x88uy; 0x6Duy; 0x61uy; 0x74uy; 0x72uy; 0x6Fuy; 0x73uy; 0x6Buy; 0x61uy|];//MKV
    [|0x25uy; 0x50uy; 0x44uy; 0x46uy|];//PDF
    [|0x00uy; 0x00uy; 0x01uy; 0xBAuy|];//MPG/VOB
    [|0x30uy; 0x26uy; 0xB2uy; 0x75uy; 0x8Euy; 0x66uy; 0xCFuy; 0x11uy; 0xA6uy; 0xD9uy; 0x00uy; 0xAAuy; 0x00uy; 0x62uy; 0xCEuy; 0x6Cuy|];//WMA/WMV
    [|0x37uy; 0x7Auy; 0xBCuy; 0xAFuy; 0x27uy; 0x1Cuy|];//7z
    [|0x38uy; 0x42uy; 0x50uy; 0x53uy|];//PSD
    [|0x42uy; 0x4Duy|];//BMP
|]

let templates = [|
    [|0x43uy; 0x57uy; 0x53uy|];//SWF
    [|0x46uy; 0x57uy; 0x53uy|];//SWF
    [|0x47uy; 0x49uy; 0x46uy; 0x38uy; 0x37uy; 0x61uy|];//GIF
    [|0x47uy; 0x49uy; 0x46uy; 0x38uy; 0x39uy; 0x61uy|];//GIF
    [|0x49uy; 0x20uy; 0x49uy|];//TIFF
    [|0x49uy; 0x44uy; 0x33uy|];//MP3
    [|0x49uy; 0x49uy; 0x2Auy; 0x00uy|];//TIFF
    [|0x4Auy; 0x41uy; 0x52uy; 0x43uy; 0x53uy; 0x00uy|];//JAR
    [|0x4Fuy; 0x67uy; 0x67uy; 0x53uy; 0x00uy; 0x02uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy|];//OGG
    [|0x50uy; 0x4Buy; 0x03uy; 0x04uy|];//ZIP
    [|0x50uy; 0x4Buy; 0x03uy; 0x04uy; 0x14uy; 0x00uy; 0x01uy; 0x00uy; 0x63uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy|];//ZIP
    [|0x50uy; 0x4Buy; 0x03uy; 0x04uy; 0x14uy; 0x00uy; 0x06uy; 0x00uy|];//DOCX
    [|0x50uy; 0x4Buy; 0x03uy; 0x04uy; 0x14uy; 0x00uy; 0x08uy; 0x00uy; 0x08uy; 0x00uy|];//JAR
    [|0x50uy; 0x4Buy; 0x05uy; 0x06uy|];//ZIP
    [|0x50uy; 0x4Buy; 0x07uy; 0x08uy|];//ZIP
    [|0x52uy; 0x61uy; 0x72uy; 0x21uy; 0x1Auy; 0x07uy; 0x00uy|];//RAR
    [|0x66uy; 0x4Cuy; 0x61uy; 0x43uy; 0x00uy; 0x00uy; 0x00uy; 0x22uy|];//FLAC
    [|0x89uy; 0x50uy; 0x4Euy; 0x47uy; 0x0Duy; 0x0Auy; 0x1Auy; 0x0Auy|];//PNG
    [|0xD0uy; 0xCFuy; 0x11uy; 0xE0uy; 0xA1uy; 0xB1uy; 0x1Auy; 0xE1uy|];//DOC
    [|0xE3uy; 0x10uy; 0x00uy; 0x01uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy|];//INFO
|]

let additional = [|
    [|0x00uy; 0x00uy; 0x00uy; 0x0Cuy; 0x6Auy; 0x50uy; 0x20uy; 0x20uy; 0x0Duy; 0x0Auy|];//JP2
    [|0x00uy; 0x00uy; 0x01uy; 0x00uy|];//ICO
    [|0x00uy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0xFFuy; 0x00uy; 0x00uy; 0x02uy; 0x00uy; 0x01uy|];//MDF
    [|0x01uy; 0x00uy; 0x09uy; 0x00uy; 0x00uy; 0x03uy|];//WMF
    [|0x09uy; 0x08uy; 0x10uy; 0x00uy; 0x00uy; 0x06uy; 0x05uy; 0x00uy|];//XLS
    [|0x0Fuy; 0x00uy; 0xE8uy; 0x03uy|];//PPT
    [|0x1Fuy; 0x8Buy; 0x08uy|];//GZ/TGZ
    [|0x3Cuy; 0x21uy; 0x64uy; 0x6Fuy; 0x63uy; 0x74uy; 0x79uy; 0x70uy|];//HTML
    [|0x3Cuy; 0x3Fuy; 0x78uy; 0x6Duy; 0x6Cuy; 0x20uy; 0x76uy; 0x65uy; 0x72uy; 0x73uy; 0x69uy; 0x6Fuy; 0x6Euy; 0x3Duy|];//MANIFEST
    [|0x3Cuy; 0x3Fuy; 0x78uy; 0x6Duy; 0x6Cuy; 0x20uy; 0x76uy; 0x65uy; 0x72uy; 0x73uy; 0x69uy; 0x6Fuy; 0x6Euy; 0x3Duy; 0x22uy; 0x31uy; 0x2Euy; 0x30uy; 0x22uy; 0x3Fuy; 0x3Euy|];//XUL
    [|0x3Fuy; 0x5Fuy; 0x03uy; 0x00uy|];//HLP
    [|0x43uy; 0x6Cuy; 0x69uy; 0x65uy; 0x6Euy; 0x74uy; 0x20uy; 0x55uy; 0x72uy; 0x6Cuy; 0x43uy; 0x61uy; 0x63uy; 0x68uy; 0x65uy; 0x20uy; 0x4Duy; 0x4Duy; 0x46uy; 0x20uy; 0x56uy; 0x65uy; 0x72uy; 0x20uy|];//DAT
    [|0x49uy; 0x53uy; 0x63uy; 0x28uy|];//CAB
    [|0x49uy; 0x54uy; 0x53uy; 0x46uy|];//CHM
    [|0x4Duy; 0x4Duy; 0x00uy; 0x2Auy|];//TIFF
    [|0x4Duy; 0x4Duy; 0x00uy; 0x2Buy|];//TIFF
    [|0x4Duy; 0x54uy; 0x68uy; 0x64uy|];//MIDI
    [|0x4Duy; 0x5Auy|];//EXE/DLL
    [|0x4Duy; 0x5Auy; 0x90uy; 0x00uy; 0x03uy; 0x00uy; 0x00uy; 0x00uy|];//API
    [|0x4Duy; 0x69uy; 0x63uy; 0x72uy; 0x6Fuy; 0x73uy; 0x6Fuy; 0x66uy; 0x74uy; 0x20uy; 0x43uy; 0x2Fuy; 0x43uy; 0x2Buy; 0x2Buy; 0x20uy|];//PDB
|]

let matcher = new Brahman.Substrings.Matcher.Matcher(1,1)

do matcher.AhoCorasik(0, (Array.append first templates))
do matcher.RabinKarp (0, (Array.append first templates))
do matcher.Hashtable (0, (Array.append first templates))
do matcher.NaiveSearch(0, (Array.append first templates))