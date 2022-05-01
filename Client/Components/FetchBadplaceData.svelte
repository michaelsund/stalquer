<script>
  import {badplaceData} from '../js/stores';
  import {onMount} from 'svelte';
  let data;
  // eslint-disable-next-line no-undef
  const apiUrl = API_URL;
  onMount(async () => {
    data = await fetch(apiUrl + '/badplace').then(x => x.json());
    badplaceData.set(data);
  });
</script>
