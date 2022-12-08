<div align="center">
  
  <h1> Simple Encryption </h1>
  <p> Is it really simple? </p>
  
  <div>
    <a href="">
      <img src="https://img.shields.io/github/last-commit/psp515/SimpleEncryption" alt="last update" />
    </a>
    <a href="https://github.com/psp515/SimpleEncryption/network/members">
      <img src="https://img.shields.io/github/forks/psp515/SimpleEncryption" alt="forks" />
    </a>
    <a href="https://github.com/psp515/SimpleEncryption/stargazers">
      <img src="https://img.shields.io/github/stars/psp515/SimpleEncryption" alt="stars" />
    </a>
    <a href="https://github.com/psp515/SimpleEncryption/issues/">
      <img src="https://img.shields.io/github/issues/psp515/SimpleEncryption" alt="open issues" />
    </a>
  </div>
</div>  

<br/>

### About The Project

Simple console app that encode/decode given string. User will be able to attach encoded/decoded file. Application wil be creating 2 files after encode (one with encoded message and one with full info) and 1 after decode ( file will contain decoded message). App is using simple ciphers, cipher list below.  

### Built With

<div>
  <a>
    <img src="https://img.shields.io/badge/-CSharp-2E8B57?logo=csharp" />
  </a>
</div>

### Getting Started

In order to use program download the repository and run it in VS or VSC.

#### Enocde
User writes the message in console or throws file to "ToEncode" folder and writes only file name Then app is randomly selecting 3 ciphers and
encoding the message. Then application shows route to your encoded files and basic informations (Encoded folder).

- *Input: Message*
- *Output: EncodedMessage, PublicKey, PrivateKey*

#### Deccode
User writes writes the DecodeKey in console and after that user writes the message or throws file to "ToDecode" folder and writes its name in console. After that app is Decoding Message with given key. After decoding application writes the message in console and creates file (Decoded folder)

- *Input: EncodedMessage, PublicKey/PrivateKey*
- *Output: Message*

### Usage 

Repository shows how some simple ciphers works.

### Roadmap

Planning refreshing repository in future 

### Contact

<div align="center">
  <a href="https://www.linkedin.com/in/lukasz-psp515-kolber/">
    <img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn" />
  </a>
  <a href="https://twitter.com/psp515">
    <img src="https://img.shields.io/badge/Twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white" alt="Twitter" />
  </a>
</div>
