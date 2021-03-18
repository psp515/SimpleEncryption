# SimpleEncryption

## Short Description
Simple console app that encode/decode given string (in future encoding content in .txt file). App is using simple ciphers, cipher list below.

### Enocde
User writes the message in console (in future copies txt file route) then app is randomly selecting 3 ciphers, 
encoding the message with use of selected ciphers and creating DecodeKey.

Last thing is checking if Encoding was succesfull, it means app is decoding message with key and checking if decoded message equals message.

*Input: Message*
*Output: EncodedMessage, DecodeKey*

### Deccode
User writes in console the message and the DecodeKey then app is Decoding Message with given key.

*Input: EncodedMessage, DecodeKey*
*Output: Message*


### App Parts
- [ ] Ciphers - simple welcome short description of app.
- [ ] ConsoleOperating - Encode,Decode and visal aspects of app.
- [ ] Helpers - Usefull methods.

#### ConsoleOperating
- [X] Starting
- [ ] Encode 
- [ ] Decode

#### Ciphers
- [ ] Cesar
- [ ] Cesar Variation
- [ ] My Substitution Cipher
- [X] Fence Cipher
- [ ] Condi Cipher
- [X] Base64
- [ ] Base91
- [ ] Scytale
- [ ] Enigma

#### Helpers
- [ ] Usefull methods with Visual aspects
- [ ] Usefull methods with Encoding/Decoding

#### Used Environments 
- **C#**
- **.NET Core**
