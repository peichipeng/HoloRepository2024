PGDMP  '                     |            holorepository1    16.3    16.3 X    S           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            T           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            U           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            V           1262    17209    holorepository1    DATABASE     �   CREATE DATABASE holorepository1 WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United Kingdom.936';
    DROP DATABASE holorepository1;
                postgres    false            �            1259    17222 	   dicomfile    TABLE     u   CREATE TABLE public.dicomfile (
    dicom_id integer NOT NULL,
    organ_id integer NOT NULL,
    dicom_path text
);
    DROP TABLE public.dicomfile;
       public         heap    postgres    false            �            1259    17227    dicomfile_dicom_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dicomfile_dicom_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.dicomfile_dicom_id_seq;
       public          postgres    false    215            W           0    0    dicomfile_dicom_id_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNED BY public.dicomfile.dicom_id;
          public          postgres    false    216            �            1259    17228    dicomsegmentation    TABLE     �   CREATE TABLE public.dicomsegmentation (
    dicom_segmentation_id integer NOT NULL,
    dicom_id integer NOT NULL,
    segmentation_path text
);
 %   DROP TABLE public.dicomsegmentation;
       public         heap    postgres    false            �            1259    17233 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE     �   CREATE SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 B   DROP SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq;
       public          postgres    false    217            X           0    0 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE OWNED BY     {   ALTER SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq OWNED BY public.dicomsegmentation.dicom_segmentation_id;
          public          postgres    false    218            �            1259    17234    donor    TABLE     �   CREATE TABLE public.donor (
    donor_id integer NOT NULL,
    age integer NOT NULL,
    date_of_death date NOT NULL,
    cause_of_death text NOT NULL,
    "timestamp" timestamp with time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.donor;
       public         heap    postgres    false            �            1259    17240    donor_donor_id_seq    SEQUENCE     �   CREATE SEQUENCE public.donor_donor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.donor_donor_id_seq;
       public          postgres    false    219            Y           0    0    donor_donor_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.donor_donor_id_seq OWNED BY public.donor.donor_id;
          public          postgres    false    220            �            1259    17241    model3d    TABLE     j   CREATE TABLE public.model3d (
    model_id integer NOT NULL,
    organ_id integer,
    model_path text
);
    DROP TABLE public.model3d;
       public         heap    postgres    false            �            1259    17246    model3d_model_id_seq    SEQUENCE     �   CREATE SEQUENCE public.model3d_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.model3d_model_id_seq;
       public          postgres    false    221            Z           0    0    model3d_model_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.model3d_model_id_seq OWNED BY public.model3d.model_id;
          public          postgres    false    222            �            1259    17247    organ    TABLE     �   CREATE TABLE public.organ (
    organ_id integer NOT NULL,
    donor_id integer NOT NULL,
    organ_name_id integer,
    organ_side text
);
    DROP TABLE public.organ;
       public         heap    postgres    false            �            1259    17252    organ_organ_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organ_organ_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.organ_organ_id_seq;
       public          postgres    false    223            [           0    0    organ_organ_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.organ_organ_id_seq OWNED BY public.organ.organ_id;
          public          postgres    false    224            �            1259    17253 	   organname    TABLE     z   CREATE TABLE public.organname (
    organ_name_id integer NOT NULL,
    organ_name text,
    has_side boolean NOT NULL
);
    DROP TABLE public.organname;
       public         heap    postgres    false            �            1259    17258    organname_organ_name_id_seq    SEQUENCE     �   CREATE SEQUENCE public.organname_organ_name_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.organname_organ_name_id_seq;
       public          postgres    false    225            \           0    0    organname_organ_name_id_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.organname_organ_name_id_seq OWNED BY public.organname.organ_name_id;
          public          postgres    false    226            �            1259    17259    organtag    TABLE     ]   CREATE TABLE public.organtag (
    organ_id integer NOT NULL,
    tag_id integer NOT NULL
);
    DROP TABLE public.organtag;
       public         heap    postgres    false            �            1259    17262    segmentation    TABLE     }   CREATE TABLE public.segmentation (
    segmentation_id integer NOT NULL,
    slice_id integer,
    segmentation_path text
);
     DROP TABLE public.segmentation;
       public         heap    postgres    false            �            1259    17267     segmentation_segmentation_id_seq    SEQUENCE     �   CREATE SEQUENCE public.segmentation_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.segmentation_segmentation_id_seq;
       public          postgres    false    228            ]           0    0     segmentation_segmentation_id_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNED BY public.segmentation.segmentation_id;
          public          postgres    false    229            �            1259    17268 
   sliceimage    TABLE     �   CREATE TABLE public.sliceimage (
    slice_id integer NOT NULL,
    organ_id integer,
    dicom_id integer,
    additional_info text,
    image_path text
);
    DROP TABLE public.sliceimage;
       public         heap    postgres    false            �            1259    17273    sliceimage_slice_id_seq    SEQUENCE     �   CREATE SEQUENCE public.sliceimage_slice_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.sliceimage_slice_id_seq;
       public          postgres    false    230            ^           0    0    sliceimage_slice_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.sliceimage_slice_id_seq OWNED BY public.sliceimage.slice_id;
          public          postgres    false    231            �            1259    17274    tag    TABLE     U   CREATE TABLE public.tag (
    tag_id integer NOT NULL,
    tag_name text NOT NULL
);
    DROP TABLE public.tag;
       public         heap    postgres    false            �            1259    17279    tag_tag_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tag_tag_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.tag_tag_id_seq;
       public          postgres    false    232            _           0    0    tag_tag_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.tag_tag_id_seq OWNED BY public.tag.tag_id;
          public          postgres    false    233            �            1259    17280 
   texturemap    TABLE     x   CREATE TABLE public.texturemap (
    texture_id integer NOT NULL,
    segmentation_id integer,
    texture_path text
);
    DROP TABLE public.texturemap;
       public         heap    postgres    false            �            1259    17285    texturemap_texture_id_seq    SEQUENCE     �   CREATE SEQUENCE public.texturemap_texture_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.texturemap_texture_id_seq;
       public          postgres    false    234            `           0    0    texturemap_texture_id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.texturemap_texture_id_seq OWNED BY public.texturemap.texture_id;
          public          postgres    false    235            �           2604    25389    dicomfile dicom_id    DEFAULT     x   ALTER TABLE ONLY public.dicomfile ALTER COLUMN dicom_id SET DEFAULT nextval('public.dicomfile_dicom_id_seq'::regclass);
 A   ALTER TABLE public.dicomfile ALTER COLUMN dicom_id DROP DEFAULT;
       public          postgres    false    216    215            �           2604    17289 '   dicomsegmentation dicom_segmentation_id    DEFAULT     �   ALTER TABLE ONLY public.dicomsegmentation ALTER COLUMN dicom_segmentation_id SET DEFAULT nextval('public.dicomsegmentation_dicom_segmentation_id_seq'::regclass);
 V   ALTER TABLE public.dicomsegmentation ALTER COLUMN dicom_segmentation_id DROP DEFAULT;
       public          postgres    false    218    217            �           2604    25390    donor donor_id    DEFAULT     p   ALTER TABLE ONLY public.donor ALTER COLUMN donor_id SET DEFAULT nextval('public.donor_donor_id_seq'::regclass);
 =   ALTER TABLE public.donor ALTER COLUMN donor_id DROP DEFAULT;
       public          postgres    false    220    219            �           2604    25391    model3d model_id    DEFAULT     t   ALTER TABLE ONLY public.model3d ALTER COLUMN model_id SET DEFAULT nextval('public.model3d_model_id_seq'::regclass);
 ?   ALTER TABLE public.model3d ALTER COLUMN model_id DROP DEFAULT;
       public          postgres    false    222    221            �           2604    25392    organ organ_id    DEFAULT     p   ALTER TABLE ONLY public.organ ALTER COLUMN organ_id SET DEFAULT nextval('public.organ_organ_id_seq'::regclass);
 =   ALTER TABLE public.organ ALTER COLUMN organ_id DROP DEFAULT;
       public          postgres    false    224    223            �           2604    25393    organname organ_name_id    DEFAULT     �   ALTER TABLE ONLY public.organname ALTER COLUMN organ_name_id SET DEFAULT nextval('public.organname_organ_name_id_seq'::regclass);
 F   ALTER TABLE public.organname ALTER COLUMN organ_name_id DROP DEFAULT;
       public          postgres    false    226    225            �           2604    25394    segmentation segmentation_id    DEFAULT     �   ALTER TABLE ONLY public.segmentation ALTER COLUMN segmentation_id SET DEFAULT nextval('public.segmentation_segmentation_id_seq'::regclass);
 K   ALTER TABLE public.segmentation ALTER COLUMN segmentation_id DROP DEFAULT;
       public          postgres    false    229    228            �           2604    25395    sliceimage slice_id    DEFAULT     z   ALTER TABLE ONLY public.sliceimage ALTER COLUMN slice_id SET DEFAULT nextval('public.sliceimage_slice_id_seq'::regclass);
 B   ALTER TABLE public.sliceimage ALTER COLUMN slice_id DROP DEFAULT;
       public          postgres    false    231    230            �           2604    25396 
   tag tag_id    DEFAULT     h   ALTER TABLE ONLY public.tag ALTER COLUMN tag_id SET DEFAULT nextval('public.tag_tag_id_seq'::regclass);
 9   ALTER TABLE public.tag ALTER COLUMN tag_id DROP DEFAULT;
       public          postgres    false    233    232            �           2604    25397    texturemap texture_id    DEFAULT     ~   ALTER TABLE ONLY public.texturemap ALTER COLUMN texture_id SET DEFAULT nextval('public.texturemap_texture_id_seq'::regclass);
 D   ALTER TABLE public.texturemap ALTER COLUMN texture_id DROP DEFAULT;
       public          postgres    false    235    234            <          0    17222 	   dicomfile 
   TABLE DATA           C   COPY public.dicomfile (dicom_id, organ_id, dicom_path) FROM stdin;
    public          postgres    false    215   �d       >          0    17228    dicomsegmentation 
   TABLE DATA           _   COPY public.dicomsegmentation (dicom_segmentation_id, dicom_id, segmentation_path) FROM stdin;
    public          postgres    false    217   �e       @          0    17234    donor 
   TABLE DATA           Z   COPY public.donor (donor_id, age, date_of_death, cause_of_death, "timestamp") FROM stdin;
    public          postgres    false    219   �e       B          0    17241    model3d 
   TABLE DATA           A   COPY public.model3d (model_id, organ_id, model_path) FROM stdin;
    public          postgres    false    221   zf       D          0    17247    organ 
   TABLE DATA           N   COPY public.organ (organ_id, donor_id, organ_name_id, organ_side) FROM stdin;
    public          postgres    false    223   �f       F          0    17253 	   organname 
   TABLE DATA           H   COPY public.organname (organ_name_id, organ_name, has_side) FROM stdin;
    public          postgres    false    225   �f       H          0    17259    organtag 
   TABLE DATA           4   COPY public.organtag (organ_id, tag_id) FROM stdin;
    public          postgres    false    227   Pg       I          0    17262    segmentation 
   TABLE DATA           T   COPY public.segmentation (segmentation_id, slice_id, segmentation_path) FROM stdin;
    public          postgres    false    228   |g       K          0    17268 
   sliceimage 
   TABLE DATA           _   COPY public.sliceimage (slice_id, organ_id, dicom_id, additional_info, image_path) FROM stdin;
    public          postgres    false    230   �g       M          0    17274    tag 
   TABLE DATA           /   COPY public.tag (tag_id, tag_name) FROM stdin;
    public          postgres    false    232   %h       O          0    17280 
   texturemap 
   TABLE DATA           O   COPY public.texturemap (texture_id, segmentation_id, texture_path) FROM stdin;
    public          postgres    false    234   �h       a           0    0    dicomfile_dicom_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.dicomfile_dicom_id_seq', 311, true);
          public          postgres    false    216            b           0    0 +   dicomsegmentation_dicom_segmentation_id_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('public.dicomsegmentation_dicom_segmentation_id_seq', 1, false);
          public          postgres    false    218            c           0    0    donor_donor_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.donor_donor_id_seq', 1, true);
          public          postgres    false    220            d           0    0    model3d_model_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.model3d_model_id_seq', 10, true);
          public          postgres    false    222            e           0    0    organ_organ_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.organ_organ_id_seq', 14, true);
          public          postgres    false    224            f           0    0    organname_organ_name_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.organname_organ_name_id_seq', 6, true);
          public          postgres    false    226            g           0    0     segmentation_segmentation_id_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.segmentation_segmentation_id_seq', 1, false);
          public          postgres    false    229            h           0    0    sliceimage_slice_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.sliceimage_slice_id_seq', 18, true);
          public          postgres    false    231            i           0    0    tag_tag_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.tag_tag_id_seq', 9, true);
          public          postgres    false    233            j           0    0    texturemap_texture_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.texturemap_texture_id_seq', 1, false);
          public          postgres    false    235            �           2606    17303    dicomfile dicomfile_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT dicomfile_pkey PRIMARY KEY (dicom_id);
 B   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT dicomfile_pkey;
       public            postgres    false    215            �           2606    17305 (   dicomsegmentation dicomsegmentation_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicomsegmentation_pkey PRIMARY KEY (dicom_segmentation_id);
 R   ALTER TABLE ONLY public.dicomsegmentation DROP CONSTRAINT dicomsegmentation_pkey;
       public            postgres    false    217            �           2606    17307    donor donor_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.donor
    ADD CONSTRAINT donor_pkey PRIMARY KEY (donor_id);
 :   ALTER TABLE ONLY public.donor DROP CONSTRAINT donor_pkey;
       public            postgres    false    219            �           2606    17309    model3d model3d_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT model3d_pkey PRIMARY KEY (model_id);
 >   ALTER TABLE ONLY public.model3d DROP CONSTRAINT model3d_pkey;
       public            postgres    false    221            �           2606    17311    organ organ_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_pkey PRIMARY KEY (organ_id);
 :   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_pkey;
       public            postgres    false    223            �           2606    17313    organname organname_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.organname
    ADD CONSTRAINT organname_pkey PRIMARY KEY (organ_name_id);
 B   ALTER TABLE ONLY public.organname DROP CONSTRAINT organname_pkey;
       public            postgres    false    225            �           2606    17315    organtag organtag_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organtag_pkey PRIMARY KEY (organ_id, tag_id);
 @   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organtag_pkey;
       public            postgres    false    227    227            �           2606    17317    segmentation segmentation_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT segmentation_pkey PRIMARY KEY (segmentation_id);
 H   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT segmentation_pkey;
       public            postgres    false    228            �           2606    17319    sliceimage sliceimage_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT sliceimage_pkey PRIMARY KEY (slice_id);
 D   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT sliceimage_pkey;
       public            postgres    false    230            �           2606    17321    tag tag_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.tag
    ADD CONSTRAINT tag_pkey PRIMARY KEY (tag_id);
 6   ALTER TABLE ONLY public.tag DROP CONSTRAINT tag_pkey;
       public            postgres    false    232            �           2606    17323    texturemap texturemap_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT texturemap_pkey PRIMARY KEY (texture_id);
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT texturemap_pkey;
       public            postgres    false    234            �           2606    17334    sliceimage dicom_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT dicom_id;
       public          postgres    false    215    230    4749            �           2606    17339    dicomsegmentation dicom_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON UPDATE CASCADE ON DELETE CASCADE;
 D   ALTER TABLE ONLY public.dicomsegmentation DROP CONSTRAINT dicom_id;
       public          postgres    false    4749    217    215            �           2606    17344    organ donor_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT donor_id FOREIGN KEY (donor_id) REFERENCES public.donor(donor_id) ON UPDATE CASCADE ON DELETE CASCADE;
 8   ALTER TABLE ONLY public.organ DROP CONSTRAINT donor_id;
       public          postgres    false    223    4753    219            �           2606    17349    organtag organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 ;   ALTER TABLE ONLY public.organtag DROP CONSTRAINT organ_id;
       public          postgres    false    4757    223    227            �           2606    17354    model3d organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 :   ALTER TABLE ONLY public.model3d DROP CONSTRAINT organ_id;
       public          postgres    false    221    223    4757            �           2606    17359    sliceimage organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 =   ALTER TABLE ONLY public.sliceimage DROP CONSTRAINT organ_id;
       public          postgres    false    230    223    4757            �           2606    17364    dicomfile organ_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;
 <   ALTER TABLE ONLY public.dicomfile DROP CONSTRAINT organ_id;
       public          postgres    false    223    4757    215            �           2606    17369    organ organ_name_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_name_id FOREIGN KEY (organ_name_id) REFERENCES public.organname(organ_name_id);
 =   ALTER TABLE ONLY public.organ DROP CONSTRAINT organ_name_id;
       public          postgres    false    4759    225    223            �           2606    17374    texturemap segmentation_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT segmentation_id FOREIGN KEY (segmentation_id) REFERENCES public.segmentation(segmentation_id) ON DELETE CASCADE;
 D   ALTER TABLE ONLY public.texturemap DROP CONSTRAINT segmentation_id;
       public          postgres    false    228    234    4763            �           2606    17379    segmentation slice_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT slice_id FOREIGN KEY (slice_id) REFERENCES public.sliceimage(slice_id) ON DELETE CASCADE;
 ?   ALTER TABLE ONLY public.segmentation DROP CONSTRAINT slice_id;
       public          postgres    false    4765    230    228            �           2606    17384    organtag tag_id    FK CONSTRAINT     �   ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT tag_id FOREIGN KEY (tag_id) REFERENCES public.tag(tag_id) ON DELETE CASCADE;
 9   ALTER TABLE ONLY public.organtag DROP CONSTRAINT tag_id;
       public          postgres    false    4767    227    232            <   �   x���=
�@E�:�ü�{�jE�70�`�L��1�k}s�;��Ad����v�����[[���O����su�D`b0f`a0*��2���`ݡzP��	G�hdg41�3��-�*�8��A�Qcg�gg��?cۙx�Eq��8c�A��� Θ2�3V�3�3�{Pę6:�p�bG      >      x������ � �      @   �   x�]�A
!��+�EG�}K.�뒅�a1�O�@ ע�ac@���l|�*��k��j���ⳍ�ޜW6��8�q�q�UK������1|,3e��{�u�K	�e�.y��x�ڨ��%E��0��n�Ro܁'c      B   <   x�3�44����44�LI,I����OI�1v����L�K��/I-.�7 ���$�=... ��Y      D   $   x�34��?.C#N#NS0˘}R�J�b���� sdO      F   F   x�3��HM,*�L�2��)�K�,�2���L�K�2M8}2�R�����NE��y@�gpI~nbr����� i<�      H      x�34�4�24�4�24������� ��      I      x������ � �      K   |   x�u�1�0@��9	�l�P�2�`c�bS�)
^�=s8�� �3$]VHb�m�w=/2i��O*�<"�g�q�|M�v@<~iy[�ki�Uri#P¿}�/9�l���mC��s�=8m      M   q   x��=�@�z�SxMP��$PHah���0a�e7�n�{u�g�U�3�Ɠ�\h������!�<�[���S9���Fm���`eÝ:��zg^�C+b�FGC�n	��?#Q!      O      x������ � �     