import { ref } from 'vue'

export default function(uri) {

  const data = ref(null);

  const getData = async () => {
    try {
      let result = await fetch(uri);
      if(!result.ok) {
        throw Error('fetch data 失敗');
      }
      data.value = await result.json();
    } catch(error) {
      throw Error(error)
    }
  }

  return { data, getData }

}