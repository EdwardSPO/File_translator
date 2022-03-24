<template>
    <div>

        <h1>Traductor</h1>
<div class="header"></div>
        <div class="container">
       <div class="mb-3">

  <input class="form-control" type="file" id="formFile" accept="image/*" @change="previerRecords">

</div>

<div class="input-group mb-3">
  <label class="input-group-text" for="inputGroupSelect01">Idioma</label>
  <select class="form-select" id="inputGroupSelect01">
    <option selected>Seleccione el idioma</option>
    <option value="1"></option>
    <option value="2"></option>
    <option value="3"></option>
  </select>
</div>
<br>

<p>Progress: {{uploadValue.toFixed()+"%"}}
  <progress :value="uploadValue" max='100'></progress>
</p>

<div class="btn-group" role="group" aria-label="Basic mixed styles example">

  <button id="traduccion" type="button" class="btn btn-success" @click="onUpload" >Traducir</button>
</div>
        
</div>
    </div>
</template>
<script>
import firebase from 'firebase/compat/app';
import 'firebase/storage';
export default {
  name: 'Upload',
  data(){	  
	return{
      recordData: null,  
      record: null,
      uploadValue: 0
	}
  },
  methods:{
    previerRecords(event) {
      this.uploadValue=0;
      this.record=null;
      this.recordData = event.target.files[0];
    },
    onUpload(){
      this.record=null;
      const storageRef=firebase.storage().ref(`${this.recordData.name}`).put(this.recordData);
      storageRef.on(`state_changed`,snapshot=>{
        this.uploadValue = (snapshot.bytesTransferred/snapshot.totalBytes)*100;
      }, error=>{console.log(error.message)},
      ()=>{this.uploadValue=100;
        storageRef.snapshot.ref.getDownloadURL().then((url)=>{
          this.record =url;
        });
      }      
      );
    }
  
  }
}
</script>
<style scoped>
.header{
  position:absolute;
  background-color: rgb(13, 70, 51);
  width: 2365px;
height: 65px;
  top:-15px;
}

h1{
   position:absolute;
  color:darkgreen;
  top:80px;
  left: 800px;
}

.form-control{
position: absolute;
top: 250px;
left: 320px;
width: 1365px;
height: 40px;
}



.form-select{
position: absolute;
top: 300px;
left: 80px;
width: 100px;
height: 40px;
}


.input-group-text{
position: absolute;
top: 300px;
left: 10px;
height: 40px;
}

/* .container{
position:absolute;
    border: 2px solid green;
    top: 290px;
} */

.btn{
  position:absolute;
  top: 350px;
left: 650px;
}


</style>