// Pseudocodes 
// 1. change texts into an array 
// 2. create an object to store the frequency count of each word
// 3. change an object of words and thier frequency into arrays 
// 4. sort the words based on thier frequency 
// 5. return the array 
// Word Frequency Analyzer

const wordFrequencyAnalyzer = text =>{
    const words = text.toLowerCase().split(/\W+/);
    const wordFrequency = {};
  // array to object 
  for(let i = 0; i<words.length;i++){
    let word = words[i];
    wordFrequency[word]= (wordFrequency[word] || 0) + 1;
  }
  // object to array 
 const wordFrequencyArr = Object.entries(wordFrequency);
 // sort arr by word frequency 
wordFrequencyArr.sort((a,b)=>b[1] - a[1]);
return wordFrequencyArr;
}






