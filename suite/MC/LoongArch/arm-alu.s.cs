# CS_ARCH_LOONGARCH, CS_MODE_LOONGARCH64, None
0x91,0x14,0x37,0x00 = armadd.w $a0, $a1, 1
0x91,0x94,0x37,0x00 = armsub.w $a0, $a1, 1
0x91,0x14,0x38,0x00 = armadc.w $a0, $a1, 1
0x91,0x94,0x38,0x00 = armsbc.w $a0, $a1, 1
0x91,0x14,0x39,0x00 = armand.w $a0, $a1, 1
0x91,0x94,0x39,0x00 = armor.w $a0, $a1, 1
0x91,0x14,0x3a,0x00 = armxor.w $a0, $a1, 1
0x9c,0xc4,0x3f,0x00 = armnot.w $a0, 1
