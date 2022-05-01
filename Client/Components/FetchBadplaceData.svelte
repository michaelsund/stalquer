<script>
  import {badplaceData} from '../js/stores';
  import {onMount} from 'svelte';
  let data;
  // eslint-disable-next-line no-undef
  const isProd = stalquerEnv.env.isProd;
  // eslint-disable-next-line no-undef
  const apiUrl = stalquerEnv.env.API_URL;
  onMount(async () => {
    data = await fetch(isProd ? apiUrl + '/badplace' : 'https://localhost:5001/badplace').then(x => x.json());
    badplaceData.set(data);
  });
</script>
