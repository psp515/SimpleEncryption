# SimpleEncryption

## Short Description
Simple console app that encode/decode given string. App is using simple ciphers, cipher list below.

### Enocde
User writes the message in console then app is randomly selecting 3 ciphers, 
encoding the message with use of selected ciphers and creating DecodeKey.

Last thing is checking if Encoding was succesfull, it means app is decoding message with key and checking if decoded message equals message.

- *Input: Message*
- *Output: EncodedMessage, PublicKey, PrivateKey*

### Deccode
User writes in console the message and the DecodeKey then app is Decoding Message with given key.

- *Input: EncodedMessage, PublicKey/PrivateKey*
- *Output: Message*


### App Parts
- [X] Ciphers - simple welcome short description of app.
- [X] Helpers - Usefull methods.

#### ConsoleOperating
- [X] Starting
- [X] Ending
- [X] Encode 
- [X] Decode

#### Ciphers
- [X] Cesar
- [X] Cesar Variation
- [ ] My Substitution Cipher
- [X] Fence Cipher
- [ ] Condi Cipher
- [X] Base64
- [ ] Base91
- [ ] Scytale
- [ ] Enigma



#### Used Environments 
- **C#**
- **.NET Core**
