var config = {
    apiKey: "AIzaSyDICNaiXh4TGGVcZBdBB0vtx3zjtWqEFqY",
    authDomain: "hello-word-f2491.firebaseapp.com",
    databaseURL: "https://hello-word-f2491.firebaseio.com",
    projectId: "hello-word-f2491",
    storageBucket: "hello-word-f2491.appspot.com",
    messagingSenderId: "951703688718"
};
firebase.initializeApp(config);

const db = firebase.database().ref();

db.on("value", function (snap) {
    $('#db').text(JSON.stringify(snap), null, 4);
});
