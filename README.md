# SimpleEncryption

Simple console app that encode/decode given string. User will be able to attach encoded/decoded file. Application wil be creating 2 files after encode (one with encoded message and one with full info) and 1 after decode ( file will contain decoded message). App is using simple ciphers, cipher list below.  

## Enocde
User writes the message in console or throws file to "ToEncode" folder and writes only file name Then app is randomly selecting 3 ciphers and
encoding the message. Then application shows route to your encoded files and basic informations (Encoded folder).

- *Input: Message*
- *Output: EncodedMessage, PublicKey, PrivateKey*

## Deccode
User writes writes the DecodeKey in console and after that user writes the message or throws file to "ToDecode" folder and writes its name in console. After that app is Decoding Message with given key. After decoding application writes the message in console and creates file (Decoded folder)

- *Input: EncodedMessage, PublicKey/PrivateKey*
- *Output: Message*


### App Parts
- [X] Ciphers - simple welcome short description of app.
- [X] Helpers - Usefull methods.
- [X] ConsoleControl
- [X] Models

#### ConsoleControl
- [X] GetDecodeInfo
- [X] GetEncodeInfo
- [X] End
- [X] Encode 
- [X] Decode

#### Ciphers
- [X] Cesar
- [X] Cesar Variation
- [X] Fence Cipher
- [X] Base64
- [X] Scytale
- [X] ROT13
- [X] ROT18

#### Used Environments 
- C#
- .NET Core

#### Status
- in progress
