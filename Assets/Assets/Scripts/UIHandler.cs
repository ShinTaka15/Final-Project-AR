using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [Header("Deskripsi Organ")]
    public TrackableAR[] trackables;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;

    [Header("UI Handler")]
    public TextMeshProUGUI txtNama;
    public TextMeshProUGUI txtDeskripsi;
    public GameObject panelJudul;
    public GameObject panelDeskripsi;

    public bool[] cekMarker;
    int countMarker;

    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[trackables.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < trackables.Length; i++)
        {
            if (trackables[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];

                if (!cekMarker[i])
                {
                    countMarker++;
                    cekMarker[i] = true;
                }
            }
            else
            {
                if (cekMarker[i])
                {
                    countMarker--;
                    cekMarker[i] = false;
                }
            }
        }

        PanelDeskripsi();
    }

    private void PanelDeskripsi()
    {
        if (countMarker == 0)
        {
            panelJudul.SetActive(false);
            panelDeskripsi.SetActive(false);
        }
        else
        {
            panelJudul.SetActive(true);
            panelDeskripsi.SetActive(true);
        }
    }
}
