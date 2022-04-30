<script>
  import {badplaceData} from '../js/stores';
  import {onMount} from 'svelte';
  let data;
  onMount(async () => {
    data = await fetch('https://localhost:5001/badplace').then(x => x.json());
    badplaceData.set(data);
  });
</script>
