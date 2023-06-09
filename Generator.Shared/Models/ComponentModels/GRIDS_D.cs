﻿using System.ComponentModel.DataAnnotations.Schema;
using ProtoBuf;

namespace Generator.Shared.Models.ComponentModels;

[ProtoContract]
[Table(nameof(ComponentModels.GRIDS_D))]
public class GRIDS_D: GRIDS_M
{
    public GRIDS_D()
    {
        COMP_TYPE = nameof(GRIDS_D);
    }
    //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //public new int Id { get; set; }

    [ProtoMember(1)]
    public int GD_M_REFNO { get; set; }
}



