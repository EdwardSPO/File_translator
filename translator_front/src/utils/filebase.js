import { initializeApp } from "firebase/app";
import 'firebase/storage';
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
const firebaseConfig = {
    apiKey: "AIzaSyAlYL5OSt08_M8SfMzrFu8abAHNGtJekMg",
    authDomain: "translate2-24e06.firebaseapp.com",
    projectId: "translate2-24e06",
    storageBucket: "translate2-24e06.appspot.com",
    messagingSenderId: "777902336444",
    appId: "1:777902336444:web:8995f6cc3f9707826be3b9"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
//const storageRef = firebase.storage().ref();